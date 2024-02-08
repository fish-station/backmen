﻿namespace Content.Server.Backmen.Vampiric;

[RegisterComponent]
public sealed partial class BloodsuckerRuleComponent : Component
{
    public int TotalBloodsuckers = 0;

    public List<string> SpeciesWhitelist = new()
    {
        "Human",
        "Reptilian",
        "Dwarf",
        "Oni",
        "Vox",
        "HumanoidFoxes",
    };
}
