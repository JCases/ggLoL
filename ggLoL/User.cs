using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using MaterialSkin;

namespace ggLoL
{
    public class User
    {
        protected string name { get; set; }
        private string password { get; set; }
        protected string email { get; set; }
        protected string nick { get; set; }
        protected bool verify { get; set; }
        // 0 NOT VERIFY
        // 1 VERIFY

        public User(string name, string password, string email, string nick,
            bool verify)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.nick = nick;
            this.verify = verify;
        }

        public void Save()
        {
            string fileName = this.name.ToLower() + "-profile.ggLoL";

            if (File.Exists(fileName))
                UpdateProfile(fileName);
            else
            {
                try
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    
                    // User Info
                    writer.WriteLine(this.name);
                    writer.WriteLine(GetEncryptPassword());
                    writer.WriteLine(this.email);
                    writer.WriteLine(this.nick);

                    writer.WriteLine("VerifyAccount:" + (this.verify ? "1" : "0"));

                    // Colors and Theme
                    var colors = ggLoL.msm.ColorScheme;
                    writer.WriteLine("P:" + colors.PrimaryColor.Name
                        + "|D:" + colors.DarkPrimaryColor.Name
                        + "|L:" + colors.LightPrimaryColor.Name);
                    writer.WriteLine("Accent:" + colors.AccentColor.Name
                        + "|Text:" + colors.TextColor.Name);

                    writer.WriteLine("Theme:" + ggLoL.msm.Theme.ToString());

                    writer.Close();
                }
                catch (PathTooLongException e) { MessageBox.Show(e.Message); }
                catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
                catch (IOException e) { MessageBox.Show(e.Message); }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }

        private void UpdateProfile(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);
                List<string> data = new List<string>();
                string line = reader.ReadLine();
                
                while (line != null)
                {
                    data.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();

                // User Info
                if (data[0] != this.name)
                {
                    data.RemoveAt(0);
                    data.Insert(0, this.name);
                }
                    
                if (data[1] != GetEncryptPassword())
                {
                    data.RemoveAt(1);
                    data.Insert(1, GetEncryptPassword());
                }

                if (data[2] != this.email)
                {
                    data.RemoveAt(2);
                    data.Insert(2, this.email);
                }

                if (data[3] != this.nick)
                {
                    data.RemoveAt(3);
                    data.Insert(3, this.nick);
                }

                if ((data[4] == "0" ? false : true) != verify)
                {
                    data.RemoveAt(4);
                    data.Insert(4, "VerifyAccount:" +
                        (this.verify ? "1" : "0"));
                }

                // Colors and Theme
                var colors = ggLoL.msm.ColorScheme;
                string colorsNow = "P:" + colors.PrimaryColor.Name
                    + "|D:" + colors.DarkPrimaryColor.Name
                    + "|L:" + colors.LightPrimaryColor.Name;

                if (data[5] != colorsNow)
                {
                    data.RemoveAt(5);
                    data.Insert(5, colorsNow);
                }

                string accentNow = "Accent:" + colors.AccentColor.Name
                    + "|Text:" + colors.TextColor.Name;

                if (data[6] != accentNow)
                {
                    data.RemoveAt(6);
                    data.Insert(6, accentNow);
                }

                if (data[7] != "Theme:" + ggLoL.msm.Theme.ToString())
                {
                    data.RemoveAt(7);
                    data.Insert(7, "Theme:" + ggLoL.msm.Theme.ToString());
                }

                StreamWriter writer = new StreamWriter(fileName);

                foreach (string d in data)
                    writer.WriteLine(d);

                writer.Close();
            }
            catch (PathTooLongException e) { MessageBox.Show(e.Message); }
            catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            catch (IOException e) { MessageBox.Show(e.Message); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void Load()
        {

            string[] files = Directory.GetFiles(".", "-profile.ggLoL");

            if (files.Length > 1)
            {
                // TO DO -> Option to take a Info from Users (More than 1)
                string users = "";
                foreach (string i in files)
                    users += " | " + i.Replace("-profile.ggLoL", "");

                MessageBox.Show("Users: " + users);
            }

            else if (files.Length == 1)
            {
                string fileName = files[0];

                if (!File.Exists(fileName))
                    MessageBox.Show("Error with file " + fileName);
                else
                {
                    try
                    {
                        StreamReader reader = new StreamReader(fileName);

                        // User Info
                        this.name = reader.ReadLine();
                        this.password = reader.ReadLine();
                        this.email = reader.ReadLine();
                        this.nick = reader.ReadLine();

                        this.verify = reader.ReadLine().Split(':')[1] == "0" ? false : true;

                        // Colors and Theme
                        int count = 0;

                        string coloursSave = reader.ReadLine();
                        Primary[] colour = new Primary[3];
                        
                        foreach (string i in coloursSave.Split('|'))
                        {
                            // TO DO i.Split(':')[1];
                            count++;
                        }

                        colour[0] = Primary.BlueGrey800;
                        colour[1] = Primary.BlueGrey900;
                        colour[2] = Primary.BlueGrey900;

                        Accent accent = Accent.LightBlue700;
                        TextShade shade = TextShade.WHITE;

                        string accentSave = reader.ReadLine();
                        foreach (string i in accentSave.Split('|'))
                        {
                            // TO DO i.Split(':')[1];
                        }

                        string themeSave = reader.ReadLine();

                        MaterialSkinManager.Themes theme =
                            themeSave.Split(':')[1] ==
                            MaterialSkinManager.Themes.LIGHT.ToString() ?
                            MaterialSkinManager.Themes.LIGHT
                            : MaterialSkinManager.Themes.DARK;

                        ggLoL lol = new ggLoL(theme, colour[0], colour[1], 
                            colour[2], accent, shade);

                        reader.Close();
                    }
                    catch (PathTooLongException e) { MessageBox.Show(e.Message); }
                    catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
                    catch (IOException e) { MessageBox.Show(e.Message); }
                    catch (Exception e) { MessageBox.Show(e.Message); }
                }
            }
        }

        public string GetEncryptPassword() { return Encrypter(password); }

        // Encryption Password
        private string Encrypter(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            data = new SHA256Managed().ComputeHash(data);

            return Encoding.ASCII.GetString(data);
        }
    }
}
