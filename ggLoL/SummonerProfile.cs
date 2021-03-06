﻿using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ggLoL
{
    public class SummonerProfile
    {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public long summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountId { get; set; }

        public static string fileName = "-account.json";

        public void Save()
        {
            fileName = name.ToLower() + "-" + Region.linkRegion + fileName;
            string accounts = JsonConvert.SerializeObject(this);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(accounts);
            writer.Close();
        }

        public static SummonerProfile Load(string name)
        {
            StreamReader reader = new StreamReader(name + fileName);
            string accounts = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<SummonerProfile>(accounts);
        }

        public void CreateAndSavePDF()
        {
            string fileName = "SummonerProfile-" + this.name + "-" + this.id + ".pdf";
            
            // Initialize Component
            PdfDocument pdf = new PdfDocument();

            // Values Archive PDF
            pdf.Info.Title = fileName;
            pdf.Info.Author = this.name;
            pdf.Info.Subject = "resume of the player's experience " + this.name
                + " in the video game League of Legends.";

            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Roboto", 14, XFontStyle.Bold);

            DrawPDF(pdf, page, gfx, font);

            // Save PDF and Show
            pdf.Save(fileName);
            Process.Start(fileName);
        }

        public ChampionMastery GetMaestry()
        {
            ChampionMastery cm;
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(name, APILinks.GetLink(
                    APILinks.Link.ChampionMastery), false);

                cm = JsonConvert.DeserializeObject<ChampionMastery>(connection.json);

                return cm;
            }
            catch { return null; }
        }

        public void DrawPDF(PdfDocument pdf, PdfPage page, XGraphics gfx, XFont font)
        {
            int position = 0;
            for (int i = 0; i < 6; i++)
            {
                position += 20;
                string text = "";
                switch (i)
                {
                    case 0:
                        text = "Name: " + this.name;
                        break;
                    case 1:
                        text = "Summoner Level: " + this.summonerLevel;
                        break;
                    case 2:
                        text = "ID: " + this.id;
                        break;
                    case 3:
                        text = "Account ID: " + this.accountId;
                        break;
                    case 4:
                        text = "Revision Date: " + this.revisionDate;
                        break;
                }

                gfx.DrawLine(XPens.Black, (page.Width.Point / 2) / 2, position, 
                    page.Width.Point / 2 + (page.Width.Point / 2) / 2, position);

                gfx.DrawString(text, font, XBrushes.Black,
                    new XRect(0, position + 2, page.Width.Point, page.Height.Point),
                    XStringFormats.TopCenter);
            }
        }
    }
}
