using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWords.Words
{
    /// <summary>
    /// pairs of word and it's translation
    /// </summary>
    public class Card
    {

        /// <summary>
        /// Word whitch we trying to learn
        /// </summary>
        public string StudiedVersion
        {
            get; private set;
        }

        /// <summary>
        /// translating for users language
        /// </summary>
        public string TranslatedVersion
        {
            get; private set;
        }

        public int Id
        {
            get; private set;
        }

        public Card(string studied, string translate)
        {
            StudiedVersion = studied;
            TranslatedVersion = translate;
        }

        public Card(int id, string studied, string translate)
        {
            Id = id;
            StudiedVersion = studied;
            TranslatedVersion = translate;
        }
    }
}