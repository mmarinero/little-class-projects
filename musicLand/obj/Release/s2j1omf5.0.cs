#if _DYNAMIC_XMLSERIALIZER_COMPILATION
[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
#endif
[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"5621d86f-2bba-4f38-bf02-01e46b4e27c4,", Version=@"2.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriterLyricWiki : System.Xml.Serialization.XmlSerializationWriter {

        void Write1_SongResult(object s) {
            global::MusicLand.com.wikia.lyrics.SongResult o = (global::MusicLand.com.wikia.lyrics.SongResult)s;
            WriteElementString(@"artist", @"", ((global::System.String)o.@artist), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"song", @"", ((global::System.String)o.@song), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
        }

        void Write3_SOTDResult(object s) {
            global::MusicLand.com.wikia.lyrics.SOTDResult o = (global::MusicLand.com.wikia.lyrics.SOTDResult)s;
            WriteElementString(@"artist", @"", ((global::System.String)o.@artist), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"song", @"", ((global::System.String)o.@song), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"nominatedBy", @"", ((global::System.String)o.@nominatedBy), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"reason", @"", ((global::System.String)o.@reason), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"lyrics", @"", ((global::System.String)o.@lyrics), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
        }

        void Write4_LyricsResult(object s) {
            global::MusicLand.com.wikia.lyrics.LyricsResult o = (global::MusicLand.com.wikia.lyrics.LyricsResult)s;
            WriteElementString(@"artist", @"", ((global::System.String)o.@artist), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"song", @"", ((global::System.String)o.@song), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"lyrics", @"", ((global::System.String)o.@lyrics), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            WriteElementString(@"url", @"", ((global::System.String)o.@url), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
        }

        public void Write5_postSong_flags(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"postSong_flags", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementStringRaw(@"overwriteIfExists", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)p[0])), new System.Xml.XmlQualifiedName(@"boolean", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"artist", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WriteElementString(@"song", @"", ((global::System.String)p[2]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 3) {
                WriteElementString(@"lyrics", @"", ((global::System.String)p[3]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 4) {
                WritePotentiallyReferencingElement(@"onAlbums", @"", ((global::System.String[])p[4]), null, false, false);
            }
            if (pLength > 5) {
                WriteElementString(@"flags", @"", ((global::System.String)p[5]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write6_postSong_flagsInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write7_checkSongExists(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"checkSongExists", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"song", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write8_checkSongExistsInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write9_searchArtists(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"searchArtists", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"searchString", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write10_searchArtistsInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write11_searchAlbums(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"searchAlbums", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"album", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WriteElementStringRaw(@"year", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[2])), new System.Xml.XmlQualifiedName(@"int", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write12_searchAlbumsInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write13_searchSongs(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"searchSongs", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"song", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write14_searchSongsInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write15_getSOTD(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getSOTD", @"urn:LyricWiki", null, true);
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write16_getSOTDInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write17_getSong(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getSong", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"song", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write18_getSongInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write19_getSongResult(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getSongResult", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"song", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write20_getSongResultInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write21_getArtist(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getArtist", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write22_getArtistInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write23_getAlbum(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getAlbum", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"album", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WriteElementStringRaw(@"year", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[2])), new System.Xml.XmlQualifiedName(@"int", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write24_getAlbumInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write25_getHometown(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"getHometown", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementString(@"artist", @"", ((global::System.String)p[0]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write26_getHometownInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write27_postArtist(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"postArtist", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementStringRaw(@"overwriteIfExists", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)p[0])), new System.Xml.XmlQualifiedName(@"boolean", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"artist", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WritePotentiallyReferencingElement(@"albums", @"", ((global::System.String[])p[2]), null, false, false);
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write28_postArtistInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write29_postAlbum(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"postAlbum", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementStringRaw(@"overwriteIfExists", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)p[0])), new System.Xml.XmlQualifiedName(@"boolean", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"artist", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WriteElementString(@"album", @"", ((global::System.String)p[2]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 3) {
                WriteElementStringRaw(@"year", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[3])), new System.Xml.XmlQualifiedName(@"int", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 4) {
                WriteElementString(@"asin", @"", ((global::System.String)p[4]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 5) {
                WritePotentiallyReferencingElement(@"songs", @"", ((global::System.String[])p[5]), null, false, false);
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write30_postAlbumInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        public void Write31_postSong(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            WriteStartElement(@"postSong", @"urn:LyricWiki", null, true);
            if (pLength > 0) {
                WriteElementStringRaw(@"overwriteIfExists", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)p[0])), new System.Xml.XmlQualifiedName(@"boolean", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 1) {
                WriteElementString(@"artist", @"", ((global::System.String)p[1]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 2) {
                WriteElementString(@"song", @"", ((global::System.String)p[2]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 3) {
                WriteElementString(@"lyrics", @"", ((global::System.String)p[3]), new System.Xml.XmlQualifiedName(@"string", @"http://www.w3.org/2001/XMLSchema"));
            }
            if (pLength > 4) {
                WritePotentiallyReferencingElement(@"onAlbums", @"", ((global::System.String[])p[4]), null, false, false);
            }
            WriteEndElement();
            WriteReferencedElements();
        }

        public void Write32_postSongInHeaders(object[] p) {
            WriteStartDocument();
            int pLength = p.Length;
            if (pLength > 0) {
                for (int i = 0; i < pLength; i++) {
                    if (p[i] != null) {
                        WritePotentiallyReferencingElement(null, null, p[i], p[i].GetType(), true, false);
                    }
                }
            }
            WriteReferencedElements();
        }

        protected override void InitCallbacks() {
            AddWriteCallback(typeof(global::MusicLand.com.wikia.lyrics.SongResult), @"SongResult", @"urn:LyricWiki", new System.Xml.Serialization.XmlSerializationWriteCallback(this.Write1_SongResult));
            AddWriteCallback(typeof(global::MusicLand.com.wikia.lyrics.SOTDResult), @"SOTDResult", @"urn:LyricWiki", new System.Xml.Serialization.XmlSerializationWriteCallback(this.Write3_SOTDResult));
            AddWriteCallback(typeof(global::MusicLand.com.wikia.lyrics.LyricsResult), @"LyricsResult", @"urn:LyricWiki", new System.Xml.Serialization.XmlSerializationWriteCallback(this.Write4_LyricsResult));
        }
    }

    public class XmlSerializationReaderLyricWiki : System.Xml.Serialization.XmlSerializationReader {

        object Read1_SongResult() {
            global::MusicLand.com.wikia.lyrics.SongResult o;
            o = new global::MusicLand.com.wikia.lyrics.SongResult();
            Fixup fixup = new Fixup(o, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read1_SongResult), 2);
            AddFixup(fixup);
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) { Reader.Skip(); return o; }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[0]);
                        try {
                            o.@artist = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@artist);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id5_song && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            o.@song = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@song);
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o);
                    }
                }
                else {
                    UnknownNode((object)o);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        void fixup_Read1_SongResult(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            global::MusicLand.com.wikia.lyrics.SongResult o = (global::MusicLand.com.wikia.lyrics.SongResult)fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                try {
                    o.@artist = (global::System.String)GetTarget(ids[0]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[0]), (string)ids[0]);
                }
            }
            if (ids[1] != null) {
                try {
                    o.@song = (global::System.String)GetTarget(ids[1]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[1]), (string)ids[1]);
                }
            }
        }

        object Read3_SOTDResult() {
            global::MusicLand.com.wikia.lyrics.SOTDResult o;
            o = new global::MusicLand.com.wikia.lyrics.SOTDResult();
            Fixup fixup = new Fixup(o, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read3_SOTDResult), 5);
            AddFixup(fixup);
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) { Reader.Skip(); return o; }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[0]);
                        try {
                            o.@artist = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@artist);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id5_song && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            o.@song = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@song);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id6_nominatedBy && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            o.@nominatedBy = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@nominatedBy);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id7_reason && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[3]);
                        try {
                            o.@reason = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@reason);
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id8_lyrics && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[4]);
                        try {
                            o.@lyrics = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@lyrics);
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)o);
                    }
                }
                else {
                    UnknownNode((object)o);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        void fixup_Read3_SOTDResult(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            global::MusicLand.com.wikia.lyrics.SOTDResult o = (global::MusicLand.com.wikia.lyrics.SOTDResult)fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                try {
                    o.@artist = (global::System.String)GetTarget(ids[0]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[0]), (string)ids[0]);
                }
            }
            if (ids[1] != null) {
                try {
                    o.@song = (global::System.String)GetTarget(ids[1]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[1]), (string)ids[1]);
                }
            }
            if (ids[2] != null) {
                try {
                    o.@nominatedBy = (global::System.String)GetTarget(ids[2]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[2]), (string)ids[2]);
                }
            }
            if (ids[3] != null) {
                try {
                    o.@reason = (global::System.String)GetTarget(ids[3]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[3]), (string)ids[3]);
                }
            }
            if (ids[4] != null) {
                try {
                    o.@lyrics = (global::System.String)GetTarget(ids[4]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[4]), (string)ids[4]);
                }
            }
        }

        object Read4_LyricsResult() {
            global::MusicLand.com.wikia.lyrics.LyricsResult o;
            o = new global::MusicLand.com.wikia.lyrics.LyricsResult();
            Fixup fixup = new Fixup(o, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read4_LyricsResult), 4);
            AddFixup(fixup);
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) { Reader.Skip(); return o; }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[0]);
                        try {
                            o.@artist = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@artist);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id5_song && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            o.@song = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@song);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id8_lyrics && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            o.@lyrics = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@lyrics);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id9_url && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[3]);
                        try {
                            o.@url = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(o.@url);
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o);
                    }
                }
                else {
                    UnknownNode((object)o);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        void fixup_Read4_LyricsResult(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            global::MusicLand.com.wikia.lyrics.LyricsResult o = (global::MusicLand.com.wikia.lyrics.LyricsResult)fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                try {
                    o.@artist = (global::System.String)GetTarget(ids[0]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[0]), (string)ids[0]);
                }
            }
            if (ids[1] != null) {
                try {
                    o.@song = (global::System.String)GetTarget(ids[1]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[1]), (string)ids[1]);
                }
            }
            if (ids[2] != null) {
                try {
                    o.@lyrics = (global::System.String)GetTarget(ids[2]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[2]), (string)ids[2]);
                }
            }
            if (ids[3] != null) {
                try {
                    o.@url = (global::System.String)GetTarget(ids[3]);
                }
                catch (System.InvalidCastException) {
                    throw CreateInvalidCastException(typeof(global::System.String), GetTarget(ids[3]), (string)ids[3]);
                }
            }
        }

        public object[] Read5_postSong_flagsResponse() {
            Reader.MoveToContent();
            object[] p = new object[4];
            p[0] = new global::System.Boolean();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read5_postSong_flagsResponse), 4);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[4];
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id10_dataUsed && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id11_boolean, id4_Item, out fixup.Ids[0]);
                        if (rre != null) {
                            try {
                                p[0] = (global::System.Boolean)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Boolean), rre, null);
                            }
                            Referenced(p[0]);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id5_song && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id12_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[3]);
                        try {
                            p[3] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[3]);
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read5_postSong_flagsResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
            if (ids[3] != null) {
                p[3] = GetTarget(ids[3]);
            }
        }

        public object[] Read6_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read7_checkSongExistsResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            p[0] = new global::System.Boolean();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read7_checkSongExistsResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations7 = 0;
            int readerCount7 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id11_boolean, id4_Item, out fixup.Ids[0]);
                        if (rre != null) {
                            try {
                                p[0] = (global::System.Boolean)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Boolean), rre, null);
                            }
                            Referenced(p[0]);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations7, ref readerCount7);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read7_checkSongExistsResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read8_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read9_searchArtistsResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read9_searchArtistsResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id14_ArrayOfString, id15_urnLyricWikiencodedTypes, out fixup.Ids[0]);
                        try {
                            p[0] = (global::System.String[])rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String[]), rre, null);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read9_searchArtistsResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read10_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations11 = 0;
            int readerCount11 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations11, ref readerCount11);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read11_searchAlbumsResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read11_searchAlbumsResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations13 = 0;
            int readerCount13 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id14_ArrayOfString, id15_urnLyricWikiencodedTypes, out fixup.Ids[0]);
                        try {
                            p[0] = (global::System.String[])rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String[]), rre, null);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations13, ref readerCount13);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read11_searchAlbumsResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read12_searchAlbumsResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read13_searchSongsResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read13_searchSongsResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations16 = 0;
            int readerCount16 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id16_SongResult, id17_urnLyricWiki, out fixup.Ids[0]);
                        try {
                            p[0] = (global::MusicLand.com.wikia.lyrics.SongResult)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::MusicLand.com.wikia.lyrics.SongResult), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations16, ref readerCount16);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read13_searchSongsResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read14_searchSongsResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations17 = 0;
            int readerCount17 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations17, ref readerCount17);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read15_getSOTDResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read15_getSOTDResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations19 = 0;
            int readerCount19 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id18_SOTDResult, id17_urnLyricWiki, out fixup.Ids[0]);
                        try {
                            p[0] = (global::MusicLand.com.wikia.lyrics.SOTDResult)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::MusicLand.com.wikia.lyrics.SOTDResult), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations19, ref readerCount19);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read15_getSOTDResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read16_getSOTDResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read17_getSongResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations21 = 0;
            int readerCount21 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations21, ref readerCount21);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read17_getSongResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations22 = 0;
            int readerCount22 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id13_return && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id19_LyricsResult, id17_urnLyricWiki, out fixup.Ids[0]);
                        try {
                            p[0] = (global::MusicLand.com.wikia.lyrics.LyricsResult)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::MusicLand.com.wikia.lyrics.LyricsResult), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations22, ref readerCount22);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read17_getSongResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read18_getSongResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations23 = 0;
            int readerCount23 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations23, ref readerCount23);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read19_getSongResultResponse() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read19_getSongResultResponse), 1);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[1];
            Reader.MoveToContent();
            int whileIterations25 = 0;
            int readerCount25 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id20_songResult && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id19_LyricsResult, id17_urnLyricWiki, out fixup.Ids[0]);
                        try {
                            p[0] = (global::MusicLand.com.wikia.lyrics.LyricsResult)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::MusicLand.com.wikia.lyrics.LyricsResult), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations25, ref readerCount25);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read19_getSongResultResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
        }

        public object[] Read20_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read21_getArtistResponse() {
            Reader.MoveToContent();
            object[] p = new object[2];
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read21_getArtistResponse), 2);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[2];
            Reader.MoveToContent();
            int whileIterations28 = 0;
            int readerCount28 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id21_albums && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id14_ArrayOfString, id15_urnLyricWikiencodedTypes, out fixup.Ids[0]);
                        try {
                            p[0] = (global::System.String[])rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String[]), rre, null);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations28, ref readerCount28);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read21_getArtistResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
        }

        public object[] Read22_getArtistResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations29 = 0;
            int readerCount29 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations29, ref readerCount29);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read23_getAlbumResponse() {
            Reader.MoveToContent();
            object[] p = new object[5];
            p[3] = new global::System.Int32();
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read23_getAlbumResponse), 5);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[5];
            Reader.MoveToContent();
            int whileIterations31 = 0;
            int readerCount31 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id22_amazonLink && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[0]);
                        try {
                            p[0] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id23_album && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id24_year && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id25_int, id4_Item, out fixup.Ids[3]);
                        if (rre != null) {
                            try {
                                p[3] = (global::System.Int32)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Int32), rre, null);
                            }
                            Referenced(p[3]);
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id26_songs && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id14_ArrayOfString, id15_urnLyricWikiencodedTypes, out fixup.Ids[4]);
                        try {
                            p[4] = (global::System.String[])rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String[]), rre, null);
                        }
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations31, ref readerCount31);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read23_getAlbumResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
            if (ids[3] != null) {
                p[3] = GetTarget(ids[3]);
            }
            if (ids[4] != null) {
                p[4] = GetTarget(ids[4]);
            }
        }

        public object[] Read24_getAlbumResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read25_getHometownResponse() {
            Reader.MoveToContent();
            object[] p = new object[3];
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read25_getHometownResponse), 3);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[3];
            Reader.MoveToContent();
            int whileIterations34 = 0;
            int readerCount34 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id27_country && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[0]);
                        try {
                            p[0] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[0]);
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id28_state && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id29_hometown && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations34, ref readerCount34);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read25_getHometownResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
        }

        public object[] Read26_getHometownResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read27_postArtistResponse() {
            Reader.MoveToContent();
            object[] p = new object[3];
            p[0] = new global::System.Boolean();
            Reader.MoveToContent();
            int whileIterations36 = 0;
            int readerCount36 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations36, ref readerCount36);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read27_postArtistResponse), 3);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[3];
            Reader.MoveToContent();
            int whileIterations37 = 0;
            int readerCount37 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id10_dataUsed && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id11_boolean, id4_Item, out fixup.Ids[0]);
                        if (rre != null) {
                            try {
                                p[0] = (global::System.Boolean)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Boolean), rre, null);
                            }
                            Referenced(p[0]);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id12_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations37, ref readerCount37);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read27_postArtistResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
        }

        public object[] Read28_postArtistResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations38 = 0;
            int readerCount38 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations38, ref readerCount38);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read29_postAlbumResponse() {
            Reader.MoveToContent();
            object[] p = new object[5];
            p[0] = new global::System.Boolean();
            p[3] = new global::System.Int32();
            Reader.MoveToContent();
            int whileIterations39 = 0;
            int readerCount39 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations39, ref readerCount39);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read29_postAlbumResponse), 5);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[5];
            Reader.MoveToContent();
            int whileIterations40 = 0;
            int readerCount40 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id10_dataUsed && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id11_boolean, id4_Item, out fixup.Ids[0]);
                        if (rre != null) {
                            try {
                                p[0] = (global::System.Boolean)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Boolean), rre, null);
                            }
                            Referenced(p[0]);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id23_album && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id24_year && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id25_int, id4_Item, out fixup.Ids[3]);
                        if (rre != null) {
                            try {
                                p[3] = (global::System.Int32)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Int32), rre, null);
                            }
                            Referenced(p[3]);
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id12_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[4]);
                        try {
                            p[4] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[4]);
                        paramsRead[4] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations40, ref readerCount40);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read29_postAlbumResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
            if (ids[3] != null) {
                p[3] = GetTarget(ids[3]);
            }
            if (ids[4] != null) {
                p[4] = GetTarget(ids[4]);
            }
        }

        public object[] Read30_postAlbumResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations41 = 0;
            int readerCount41 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations41, ref readerCount41);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        public object[] Read31_postSongResponse() {
            Reader.MoveToContent();
            object[] p = new object[4];
            p[0] = new global::System.Boolean();
            Reader.MoveToContent();
            int whileIterations42 = 0;
            int readerCount42 = ReaderCount;
            while (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                string root = Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
                if (root == null || System.Xml.XmlConvert.ToBoolean(root)) break;
                ReadReferencedElement();
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations42, ref readerCount42);
            }
            bool isEmptyWrapper = Reader.IsEmptyElement;
            Reader.ReadStartElement();
            Fixup fixup = new Fixup(p, new System.Xml.Serialization.XmlSerializationFixupCallback(this.fixup_Read31_postSongResponse), 4);
            AddFixup(fixup);
            IsReturnValue = true;
            bool[] paramsRead = new bool[4];
            Reader.MoveToContent();
            int whileIterations43 = 0;
            int readerCount43 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && (IsReturnValue || ((object) Reader.LocalName == (object)id10_dataUsed && (object) Reader.NamespaceURI == (object)id2_Item))) {
                        object rre = ReadReferencingElement(id11_boolean, id4_Item, out fixup.Ids[0]);
                        if (rre != null) {
                            try {
                                p[0] = (global::System.Boolean)rre;
                            }
                            catch (System.InvalidCastException) {
                                throw CreateInvalidCastException(typeof(global::System.Boolean), rre, null);
                            }
                            Referenced(p[0]);
                        }
                        IsReturnValue = false;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id1_artist && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[1]);
                        try {
                            p[1] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[1]);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id5_song && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[2]);
                        try {
                            p[2] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[2]);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id12_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        object rre = ReadReferencingElement(id3_string, id4_Item, out fixup.Ids[3]);
                        try {
                            p[3] = (global::System.String)rre;
                        }
                        catch (System.InvalidCastException) {
                            throw CreateInvalidCastException(typeof(global::System.String), rre, null);
                        }
                        Referenced(p[3]);
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)p);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations43, ref readerCount43);
            }
            if (!isEmptyWrapper) ReadEndElement();
            ReadReferencedElements();
            return p;
        }

        void fixup_Read31_postSongResponse(object objFixup) {
            Fixup fixup = (Fixup)objFixup;
            object[] p = (object[])fixup.Source;
            string[] ids = fixup.Ids;
            if (ids[0] != null) {
                p[0] = GetTarget(ids[0]);
            }
            if (ids[1] != null) {
                p[1] = GetTarget(ids[1]);
            }
            if (ids[2] != null) {
                p[2] = GetTarget(ids[2]);
            }
            if (ids[3] != null) {
                p[3] = GetTarget(ids[3]);
            }
        }

        public object[] Read32_postSongResponseOutHeaders() {
            Reader.MoveToContent();
            object[] p = new object[0];
            System.Collections.ArrayList hrefList = new System.Collections.ArrayList();
            System.Collections.ArrayList hrefListIsObject = new System.Collections.ArrayList();
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations44 = 0;
            int readerCount44 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/") == "0") {
                        if (Reader.GetAttribute("id", null) != null) { ReadReferencedElement(); } else { UnknownNode((object)p); } continue;
                    }
                    string refElemId = null;
                    object refElem = ReadReferencingElement(null, null, true, out refElemId);
                    if (refElemId != null) {
                        hrefList.Add(refElemId);
                        hrefListIsObject.Add(false);
                    }
                    else if (refElem != null) {
                        hrefList.Add(refElem);
                        hrefListIsObject.Add(true);
                    }
                }
                else {
                    UnknownNode((object)p);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations44, ref readerCount44);
            }
            int isObjectIndex = 0;
            foreach (object obj in hrefList) {
                bool isReferenced = true;
                bool isObject = (bool)hrefListIsObject[isObjectIndex++];
                object refObj = isObject ? obj : GetTarget((string)obj);
                if (refObj == null) continue;
                System.Type refObjType = refObj.GetType();
                string refObjId = null;
                isReferenced = false;
                if (isObject && isReferenced) Referenced(refObj); // need to mark this obj as ref'd since we didn't do GetTarget
            }
            ReadReferencedElements();
            return p;
        }

        protected override void InitCallbacks() {
            AddReadCallback(id14_ArrayOfString, id15_urnLyricWikiencodedTypes, typeof(global::System.String[]), new System.Xml.Serialization.XmlSerializationReadCallback(this.Read33_Array));
            AddReadCallback(id16_SongResult, id17_urnLyricWiki, typeof(global::MusicLand.com.wikia.lyrics.SongResult), new System.Xml.Serialization.XmlSerializationReadCallback(this.Read1_SongResult));
            AddReadCallback(id18_SOTDResult, id17_urnLyricWiki, typeof(global::MusicLand.com.wikia.lyrics.SOTDResult), new System.Xml.Serialization.XmlSerializationReadCallback(this.Read3_SOTDResult));
            AddReadCallback(id19_LyricsResult, id17_urnLyricWiki, typeof(global::MusicLand.com.wikia.lyrics.LyricsResult), new System.Xml.Serialization.XmlSerializationReadCallback(this.Read4_LyricsResult));
        }

        object Read33_Array() {
            // dummy array method
            UnknownNode(null);
            return null;
        }

        string id12_message;
        string id11_boolean;
        string id25_int;
        string id5_song;
        string id22_amazonLink;
        string id6_nominatedBy;
        string id19_LyricsResult;
        string id28_state;
        string id20_songResult;
        string id23_album;
        string id8_lyrics;
        string id15_urnLyricWikiencodedTypes;
        string id26_songs;
        string id2_Item;
        string id29_hometown;
        string id14_ArrayOfString;
        string id16_SongResult;
        string id10_dataUsed;
        string id24_year;
        string id17_urnLyricWiki;
        string id27_country;
        string id13_return;
        string id7_reason;
        string id9_url;
        string id4_Item;
        string id18_SOTDResult;
        string id21_albums;
        string id1_artist;
        string id3_string;

        protected override void InitIDs() {
            id12_message = Reader.NameTable.Add(@"message");
            id11_boolean = Reader.NameTable.Add(@"boolean");
            id25_int = Reader.NameTable.Add(@"int");
            id5_song = Reader.NameTable.Add(@"song");
            id22_amazonLink = Reader.NameTable.Add(@"amazonLink");
            id6_nominatedBy = Reader.NameTable.Add(@"nominatedBy");
            id19_LyricsResult = Reader.NameTable.Add(@"LyricsResult");
            id28_state = Reader.NameTable.Add(@"state");
            id20_songResult = Reader.NameTable.Add(@"songResult");
            id23_album = Reader.NameTable.Add(@"album");
            id8_lyrics = Reader.NameTable.Add(@"lyrics");
            id15_urnLyricWikiencodedTypes = Reader.NameTable.Add(@"urn:LyricWiki/encodedTypes");
            id26_songs = Reader.NameTable.Add(@"songs");
            id2_Item = Reader.NameTable.Add(@"");
            id29_hometown = Reader.NameTable.Add(@"hometown");
            id14_ArrayOfString = Reader.NameTable.Add(@"ArrayOfString");
            id16_SongResult = Reader.NameTable.Add(@"SongResult");
            id10_dataUsed = Reader.NameTable.Add(@"dataUsed");
            id24_year = Reader.NameTable.Add(@"year");
            id17_urnLyricWiki = Reader.NameTable.Add(@"urn:LyricWiki");
            id27_country = Reader.NameTable.Add(@"country");
            id13_return = Reader.NameTable.Add(@"return");
            id7_reason = Reader.NameTable.Add(@"reason");
            id9_url = Reader.NameTable.Add(@"url");
            id4_Item = Reader.NameTable.Add(@"http://www.w3.org/2001/XMLSchema");
            id18_SOTDResult = Reader.NameTable.Add(@"SOTDResult");
            id21_albums = Reader.NameTable.Add(@"albums");
            id1_artist = Reader.NameTable.Add(@"artist");
            id3_string = Reader.NameTable.Add(@"string");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReaderLyricWiki();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriterLyricWiki();
        }
    }

    public sealed class ArrayOfObjectSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSong_flags", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write5_postSong_flags((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer1 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSong_flagsResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read5_postSong_flagsResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer2 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSong_flagsInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write6_postSong_flagsInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer3 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSong_flagsResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read6_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer4 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"checkSongExists", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write7_checkSongExists((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer5 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"checkSongExistsResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read7_checkSongExistsResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer6 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"checkSongExistsInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write8_checkSongExistsInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer7 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"checkSongExistsResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read8_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer8 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchArtists", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write9_searchArtists((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer9 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchArtistsResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read9_searchArtistsResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer10 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchArtistsInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write10_searchArtistsInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer11 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchArtistsResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read10_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer12 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchAlbums", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write11_searchAlbums((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer13 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchAlbumsResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read11_searchAlbumsResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer14 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchAlbumsInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write12_searchAlbumsInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer15 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchAlbumsResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read12_searchAlbumsResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer16 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchSongs", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write13_searchSongs((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer17 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchSongsResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read13_searchSongsResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer18 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchSongsInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write14_searchSongsInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer19 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"searchSongsResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read14_searchSongsResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer20 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSOTD", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write15_getSOTD((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer21 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSOTDResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read15_getSOTDResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer22 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSOTDInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write16_getSOTDInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer23 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSOTDResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read16_getSOTDResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer24 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSong", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write17_getSong((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer25 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read17_getSongResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer26 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write18_getSongInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer27 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read18_getSongResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer28 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResult", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write19_getSongResult((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer29 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResultResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read19_getSongResultResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer30 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResultInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write20_getSongResultInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer31 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getSongResultResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read20_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer32 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getArtist", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write21_getArtist((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer33 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getArtistResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read21_getArtistResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer34 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getArtistInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write22_getArtistInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer35 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getArtistResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read22_getArtistResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer36 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getAlbum", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write23_getAlbum((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer37 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getAlbumResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read23_getAlbumResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer38 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getAlbumInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write24_getAlbumInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer39 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getAlbumResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read24_getAlbumResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer40 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getHometown", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write25_getHometown((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer41 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getHometownResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read25_getHometownResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer42 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getHometownInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write26_getHometownInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer43 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"getHometownResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read26_getHometownResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer44 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postArtist", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write27_postArtist((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer45 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postArtistResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read27_postArtistResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer46 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postArtistInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write28_postArtistInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer47 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postArtistResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read28_postArtistResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer48 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postAlbum", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write29_postAlbum((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer49 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postAlbumResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read29_postAlbumResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer50 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postAlbumInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write30_postAlbumInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer51 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postAlbumResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read30_postAlbumResponseOutHeaders();
        }
    }

    public sealed class ArrayOfObjectSerializer52 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSong", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write31_postSong((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer53 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSongResponse", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read31_postSongResponse();
        }
    }

    public sealed class ArrayOfObjectSerializer54 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSongInHeaders", @"urn:LyricWiki");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterLyricWiki)writer).Write32_postSongInHeaders((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer55 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"postSongResponseOutHeaders", @"urn:LyricWiki");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderLyricWiki)reader).Read32_postSongResponseOutHeaders();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReaderLyricWiki(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriterLyricWiki(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):Response"] = @"Read5_postSong_flagsResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):OutHeaders"] = @"Read6_Item";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):Response"] = @"Read7_checkSongExistsResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):OutHeaders"] = @"Read8_Item";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):Response"] = @"Read9_searchArtistsResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):OutHeaders"] = @"Read10_Item";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):Response"] = @"Read11_searchAlbumsResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):OutHeaders"] = @"Read12_searchAlbumsResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):Response"] = @"Read13_searchSongsResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):OutHeaders"] = @"Read14_searchSongsResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():Response"] = @"Read15_getSOTDResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():OutHeaders"] = @"Read16_getSOTDResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):Response"] = @"Read17_getSongResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):OutHeaders"] = @"Read18_getSongResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):Response"] = @"Read19_getSongResultResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):OutHeaders"] = @"Read20_Item";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):Response"] = @"Read21_getArtistResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):OutHeaders"] = @"Read22_getArtistResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):Response"] = @"Read23_getAlbumResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):OutHeaders"] = @"Read24_getAlbumResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):Response"] = @"Read25_getHometownResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):OutHeaders"] = @"Read26_getHometownResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):Response"] = @"Read27_postArtistResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):OutHeaders"] = @"Read28_postArtistResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):Response"] = @"Read29_postAlbumResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):OutHeaders"] = @"Read30_postAlbumResponseOutHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):Response"] = @"Read31_postSongResponse";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):OutHeaders"] = @"Read32_postSongResponseOutHeaders";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef)"] = @"Write5_postSong_flags";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):InHeaders"] = @"Write6_postSong_flagsInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String)"] = @"Write7_checkSongExists";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):InHeaders"] = @"Write8_checkSongExistsInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String)"] = @"Write9_searchArtists";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):InHeaders"] = @"Write10_searchArtistsInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32)"] = @"Write11_searchAlbums";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):InHeaders"] = @"Write12_searchAlbumsInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String)"] = @"Write13_searchSongs";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):InHeaders"] = @"Write14_searchSongsInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD()"] = @"Write15_getSOTD";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():InHeaders"] = @"Write16_getSOTDInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String)"] = @"Write17_getSong";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):InHeaders"] = @"Write18_getSongInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String)"] = @"Write19_getSongResult";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):InHeaders"] = @"Write20_getSongResultInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef)"] = @"Write21_getArtist";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):InHeaders"] = @"Write22_getArtistInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef)"] = @"Write23_getAlbum";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):InHeaders"] = @"Write24_getAlbumInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef)"] = @"Write25_getHometown";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):InHeaders"] = @"Write26_getHometownInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef)"] = @"Write27_postArtist";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):InHeaders"] = @"Write28_postArtistInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef)"] = @"Write29_postAlbum";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):InHeaders"] = @"Write30_postAlbumInHeaders";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef)"] = @"Write31_postSong";
                    _tmp[@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):InHeaders"] = @"Write32_postSongInHeaders";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):InHeaders", new ArrayOfObjectSerializer2());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef)", new ArrayOfObjectSerializer());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):InHeaders", new ArrayOfObjectSerializer46());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):InHeaders", new ArrayOfObjectSerializer14());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):OutHeaders", new ArrayOfObjectSerializer15());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32):Response", new ArrayOfObjectSerializer13());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):OutHeaders", new ArrayOfObjectSerializer47());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):InHeaders", new ArrayOfObjectSerializer30());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):InHeaders", new ArrayOfObjectSerializer10());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():OutHeaders", new ArrayOfObjectSerializer23());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String)", new ArrayOfObjectSerializer16());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):OutHeaders", new ArrayOfObjectSerializer35());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):InHeaders", new ArrayOfObjectSerializer34());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):Response", new ArrayOfObjectSerializer37());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):OutHeaders", new ArrayOfObjectSerializer3());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):OutHeaders", new ArrayOfObjectSerializer19());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):OutHeaders", new ArrayOfObjectSerializer11());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):Response", new ArrayOfObjectSerializer49());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef):Response", new ArrayOfObjectSerializer33());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():Response", new ArrayOfObjectSerializer21());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):InHeaders", new ArrayOfObjectSerializer18());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String)", new ArrayOfObjectSerializer4());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchAlbums(System.String, System.String, Int32)", new ArrayOfObjectSerializer12());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef):Response", new ArrayOfObjectSerializer45());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String):Response", new ArrayOfObjectSerializer9());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):Response", new ArrayOfObjectSerializer25());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef)", new ArrayOfObjectSerializer52());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef)", new ArrayOfObjectSerializer48());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String)", new ArrayOfObjectSerializer28());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] searchArtists(System.String)", new ArrayOfObjectSerializer8());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD():InHeaders", new ArrayOfObjectSerializer22());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SongResult searchSongs(System.String, System.String):Response", new ArrayOfObjectSerializer17());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):OutHeaders", new ArrayOfObjectSerializer55());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):InHeaders", new ArrayOfObjectSerializer38());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef)", new ArrayOfObjectSerializer40());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef):OutHeaders", new ArrayOfObjectSerializer39());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String)", new ArrayOfObjectSerializer24());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):InHeaders", new ArrayOfObjectSerializer6());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.SOTDResult getSOTD()", new ArrayOfObjectSerializer20());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):Response", new ArrayOfObjectSerializer5());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean checkSongExists(System.String, System.String):OutHeaders", new ArrayOfObjectSerializer7());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):Response", new ArrayOfObjectSerializer41());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String[] getArtist(System.String ByRef)", new ArrayOfObjectSerializer32());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postArtist(Boolean, System.String ByRef, System.String[], System.String ByRef)", new ArrayOfObjectSerializer44());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):OutHeaders", new ArrayOfObjectSerializer31());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):OutHeaders", new ArrayOfObjectSerializer51());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):OutHeaders", new ArrayOfObjectSerializer43());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postAlbum(Boolean, System.String ByRef, System.String ByRef, Int32 ByRef, System.String, System.String[], System.String ByRef):InHeaders", new ArrayOfObjectSerializer50());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):Response", new ArrayOfObjectSerializer53());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String ByRef):InHeaders", new ArrayOfObjectSerializer54());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getHometown(System.String, System.String ByRef, System.String ByRef):InHeaders", new ArrayOfObjectSerializer42());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:System.String getAlbum(System.String ByRef, System.String ByRef, Int32 ByRef, System.String[] ByRef)", new ArrayOfObjectSerializer36());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):InHeaders", new ArrayOfObjectSerializer26());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:Boolean postSong_flags(Boolean, System.String ByRef, System.String ByRef, System.String, System.String[], System.String, System.String ByRef):Response", new ArrayOfObjectSerializer1());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSongResult(System.String, System.String):Response", new ArrayOfObjectSerializer29());
                    _tmp.Add(@"MusicLand.com.wikia.lyrics.LyricWiki:MusicLand.com.wikia.lyrics.LyricsResult getSong(System.String, System.String):OutHeaders", new ArrayOfObjectSerializer27());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::MusicLand.com.wikia.lyrics.LyricWiki)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            return null;
        }
    }
}
