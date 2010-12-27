using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Xml.Linq;
using System.Web.Security;
using System.Xml;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.YouTube;
using Google.GData.Extensions.MediaRss;
using Google.YouTube;
using System.Web;
using MusicLand.com.wikia.lyrics;
using System.Text;
namespace MusicLand
{
    public partial class _Default : System.Web.UI.Page
    {
        YouTubeRequestSettings settings = new YouTubeRequestSettings("musicland","", "AI39si5KFbxcsOgAMIC4be_zZhKhME72R_mAeDchEQghxBU2lG3UThZWg-cZYE7833eLkhHD4iweS-Wafp8PyS5xR8N4DTCH7A");
        String embed =  @"<object width=""560"" height=""340""><param name=""movie"" value=""http://www.youtube.com/v/{0}&hl=en_US&fs=1&""></param>
                            <param name=""allowFullScreen"" value=""true""></param>
                            <param name=""allowscriptaccess"" value=""always""></param>
                            <embed src=""http://www.youtube.com/v/{0}&hl=en_US&fs=1&"" 
                            type=""application/x-shockwave-flash"" allowscriptaccess=""always"" 
                            allowfullscreen=""true"" width=""560"" height=""340""></embed></object>";
        String helpSpotify = @"<div id=""spotify""><a href=""http://spotify.com""><img alt=""spotify"" src=""images/spotify-logo.png"" style=""width: 32px; height: 32px"" /></a><p>Necesitas Spotify para disfrutar de estos enlaces</p></div>";
        Video video1;
        LyricWiki wiki = new LyricWiki();
        LyricsResult result;

        protected DataTable trackdatatable;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.Form.DefaultButton = BBuscador.UniqueID;
            trackdatatable=new DataTable();
            trackdatatable.Columns.Add(new DataColumn("Track", typeof(string)));
            trackdatatable.Columns.Add(new DataColumn("Nombre", typeof(string)));
            trackdatatable.Columns.Add(new DataColumn("Artista", typeof(string)));
            trackdatatable.Columns.Add(new DataColumn("Album", typeof(string)));
            trackdatatable.Columns.Add(new DataColumn("Duración", typeof(string)));
            trackdatatable.Columns.Add(new DataColumn("Letra", typeof(string)));
            //trackdatatable.Columns.Add(new DataColumn("Popularity", typeof(string)));
            String cancion = Request.QueryString["s"];
            String artista = Request.QueryString["a"];
            if (cancion != null && artista != null) peticionajax(cancion, artista);
            String track = Request.QueryString["search"];
            literalBuscar.Text = String.Format("<input type=\"text\" name=\"search\" id=\"TBuscador\" value=\"{0}\" />", track);
            if (track != "" && track != null) BBuscador(Request.QueryString["search"]);
        }

        protected void peticionajax(String cancion, String artista)
        {
            if (wiki.checkSongExists(artista, cancion))
            {
                result = wiki.getSong(artista, cancion);
                Response.Write("<a href=\"" + result.url + "\">letra</a>");
            }
            else Response.Write("No se encontro");
            Response.End();
        }

        protected void BBuscador(String track)
        {
            string spotUrl = String.Format("http://ws.spotify.com/search/1/track?q={0}", track);
            WebClient spotService = new WebClient();
            spotService.Encoding = Encoding.UTF8;
            spotService.DownloadStringCompleted += new DownloadStringCompletedEventHandler(SpotService_DownloadTracksCompleted);
            spotService.DownloadStringAsync(new Uri(spotUrl));

            YouTubeRequest request = new YouTubeRequest(settings);
            YouTubeQuery query = new YouTubeQuery(YouTubeQuery.DefaultVideoUri);
            query.OrderBy = "relevance";
            query.Query = track;
            query.SafeSearch = YouTubeQuery.SafeSearchValues.None;
            Feed<Video> videoFeed = request.Get<Video>(query);
            if (videoFeed.Entries.Count() > 0)
            {
                video1 = videoFeed.Entries.ElementAt(0);
                literal1.Text = String.Format(embed, video1.VideoId);
                if (videoFeed.Entries.Count() > 1)
                {
                    video1 = videoFeed.Entries.ElementAt(1);
                    literal1.Text += String.Format(embed, video1.VideoId);
                }
            }
        }
        void SpotService_DownloadTracksCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DisplayTracks(e.Result);
            }

        }
        void DisplayTracks(string xmlContent)
        {
            int i = 0;
            XmlDocument tracks = new XmlDocument();
            tracks.LoadXml(xmlContent);
            DataRow dr;
            XmlNodeList etrackslist = tracks.GetElementsByTagName("track");
            XmlElement XMLElement2;
            if (etrackslist.Count == 0) ErrorBox.Text = "No se encontraron resultados<br />";
            else ErrorBox.Text = helpSpotify;
            foreach (XmlNode node in etrackslist)
            {
                DateTime duration = new DateTime(0);
                dr = trackdatatable.NewRow();
                XmlElement XMLElement = (XmlElement)node;
                dr[0] = XMLElement.GetElementsByTagName("track-number")[0].InnerText;
                if (XMLElement.HasAttribute("href"))
                dr[1] = String.Format("<a href=\"{0}\">{1}</a>",
                    XMLElement.GetAttribute("href"),
                    XMLElement.GetElementsByTagName("name")[0].InnerText);
                XMLElement2 = (XmlElement) XMLElement.GetElementsByTagName("artist")[0];
                dr[2] = String.Format("<a href=\"{0}\">{1}</a>",
                    XMLElement2.GetAttribute("href"),
                    XMLElement2.InnerText);
                XMLElement2 = (XmlElement)XMLElement.GetElementsByTagName("album")[0];
                dr[3] = String.Format("<a href=\"{0}\">{1}</a>",
                    XMLElement2.GetAttribute("href"),
                    XMLElement2.FirstChild.InnerText);
                duration = duration.AddSeconds(float.Parse(XMLElement.GetElementsByTagName("length")[0].InnerText));
                dr[4] = duration.ToString("H:mm:ss");
                dr[5] = "<a href=\"javascript:lyricSearch(" + i.ToString() + ")\">Buscar letra</a>";
                trackdatatable.Rows.Add(dr);
                i++;
                if (i >= 20) break;
            }
            DataView dv = new DataView(trackdatatable);
            trackList.DataSource = dv;
            trackList.DataBind();
        }
    }
}
