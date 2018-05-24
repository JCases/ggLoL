using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

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
                    writer.WriteLine(colors.PrimaryColor.Name
                        + "|D:" + colors.DarkPrimaryColor.Name
                        + "|L:" + colors.LightPrimaryColor.Name);
                    writer.WriteLine("|Accent:" + colors.AccentColor.Name
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
                    data[0].Replace(data[0], this.name);
                    
                if (data[1] != GetEncryptPassword())
                    data[1].Replace(data[1], GetEncryptPassword());

                if (data[2] != this.email)
                    data[2].Replace(data[2], this.email);

                if (data[3] != this.nick)
                    data[3].Replace(data[3], this.nick);

                if ((data[4] == "0" ? true : false) != verify)
                    data[4].Replace(data[4], "VerifyAccount:" + 
                        (this.verify ? "0" : "1"));

                // Colors and Theme
                var colors = ggLoL.msm.ColorScheme;
                string colorsNow = colors.PrimaryColor.Name
                    + "|D:" + colors.DarkPrimaryColor.Name
                    + "|L:" + colors.LightPrimaryColor.Name;

                if (data[5] != colorsNow)
                    data[5].Replace(data[5], colorsNow);

                string accentNow = "|Accent:" + colors.AccentColor.Name
                    + "|Text:" + colors.TextColor.Name;

                if (data[6] != accentNow)
                    data[6].Replace(data[6], accentNow);

                if (data[7] != "Theme:" + ggLoL.msm.Theme.ToString())
                    data[7].Replace(data[7], "Theme:" + ggLoL.msm.Theme.ToString());

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

        public string GetEncryptPassword() { return Encrypter(password); }

        // Encryption Password
        private string Encrypter(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            data = new SHA256Managed().ComputeHash(data);

            return Encoding.ASCII.GetString(data);
        }

        // TO DO
        private string DecryptPassword(string password)
        {
            return password;
        }
    }
}
