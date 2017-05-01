﻿namespace PKHeX.Core
{
    public enum PIDType
    {
        /// <summary> No match </summary>
        None,

        /// <summary> Method 1 Variants (H1/J/K) </summary>
        Method_1,
        /// <summary> Method H2 </summary>
        Method_2,
        /// <summary> Method H4 </summary>
        Method_4,

        /// <summary>
        /// Event Reversed Order PID restricted to 16bit Origin Seed
        /// </summary>
        BACD_R,
        /// <summary>
        /// Event Reversed Order PID without Origin Seed restrictions
        /// </summary>
        BACD_U,
        /// <summary>
        /// Event Reversed Order PID restricted to 16bit Origin Seed, antishiny.
        /// </summary>
        BACD_R_A,
        /// <summary>
        /// Event Reversed Order PID without Origin Seed restrictions, antishiny.
        /// </summary>
        BACD_U_A,
        /// <summary>
        /// Event Reversed Order PID restricted to 16bit Origin Seed, shiny
        /// </summary>
        BACD_R_S,
        /// <summary>
        /// Event Reversed Order PID without Origin Seed restrictions, shiny
        /// </summary>
        BACD_U_S,

        /// <summary>
        /// Generation 4 Cute Charm forced 8 bit
        /// </summary>
        CuteCharm,
        /// <summary>
        /// Generation 4 Chained Shiny
        /// </summary>
        ChainShiny,

        // XDRNG Based
        CXD,
        Channel,

        // ARNG Based
        G4MGAntiShiny,

        // Formulaic
        G5MGShiny,

        // Specified
        Static,
    }
}
