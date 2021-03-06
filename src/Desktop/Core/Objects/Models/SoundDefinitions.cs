﻿using System.Collections.Generic;
using AstroSoundBoard.Core.Components;
using AstroSoundBoard.Core.Objects.DataObjects.SoundDefinitionJsonTypes;
using AstroSoundBoard.Core.Objects.Models;
using Newtonsoft.Json;

namespace AstroSoundBoard.Core.Objects.DataObjects.SoundDefinitionJsonTypes
{
    public class SoundAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InfoAttribute
    {
        [JsonProperty("VideoLink")]
        public string VideoLink { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class Definition
    {
        [JsonProperty("sound")]
        public SoundAttribute Sound { get; set; }

        [JsonProperty("info")]
        public InfoAttribute Info { get; set; }

        public SoundModel ToSoundModel()
        {
            return SoundModel.fromDefinition(SoundManager.GetSound(Sound.Name));
        }
    }
}

namespace AstroSoundBoard.Core.Objects.DataObjects.SoundDefinition
{
    public class SoundDefinitions
    {
        public SoundDefinitions()
        {
            SoundList = new List<Definition>();
        }

        [JsonProperty("FileVersion")]
        public string FileVersion { get; set; }

        [JsonProperty("ParserVersion")]
        public string ParserVersion { get; set; }

        [JsonProperty("Sounds")]
        public List<Definition> SoundList { get; set; }
    }
}