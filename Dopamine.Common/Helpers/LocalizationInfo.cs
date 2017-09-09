﻿using Digimezzo.Utilities.Utils;
using Dopamine.Core.Helpers;

namespace Dopamine.Common.Helpers
{
    public class LocalizationInfo : ILocalizationInfo
    {
        public string UnknownArtistText => ResourceUtils.GetString("Language_Unknown_Artist");

        public string UnknownGenreText => ResourceUtils.GetString("Language_Unknown_Genre");

        public string UnknownAlbumText => ResourceUtils.GetString("Language_Unknown_Album");
    }
}