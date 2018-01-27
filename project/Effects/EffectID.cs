/*
 *  "NorseWorld: Ragnarok", a roguelike game for PCs.
 *  Copyright (C) 2002-2008, 2014 by Serg V. Zhdanovskih.
 *
 *  This file is part of "NorseWorld: Ragnarok".
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace NWR.Effects
{
    public enum EffectID
    {
        eid_None = 0,
        eid_Rejuvenation = 1,
        eid_Invisibility = 2,
        eid_Invulnerable = 3,
        eid_Blessing = 4,
        eid_Confusion = 5,
        eid_Destruction = 6,
        eid_DispelHex = 7,
        eid_Traveling = 8,
        eid_Cartography = 9,
        eid_Transport = 10,
        eid_DetectItems = 11,
        eid_Cure = 12,
        eid_Fading = 13,
        eid_Intoxicate = 14,
        eid_Contamination = 15,
        eid_Blindness = 16,
        eid_Fever = 17,
        eid_Withered = 18,
        eid_Hallucination = 19,
        eid_HealInability = 20,
        eid_Poisoned = 21,
        eid_SoulSeeking = 22,
        eid_Burns = 23,
        eid_LegsMissing = 24,
        eid_Vertigo = 25,
        eid_Lycanthropy = 26,
        eid_BrainScarring = 27,
        eid_Impregnation = 28,
        eid_EyesMissing = 29,
        eid_Deafness = 30,
        eid_Fragile = 31,
        eid_Immortal = 32,
        eid_Diseased = 33,
        eid_Hardening = 34,
        eid_Draining = 35,
        eid_Relocation = 36,
        eid_Famine = 37,
        eid_Genesis = 38,
        eid_Luck = 39,
        eid_Strength = 40,
        eid_Experience = 41,
        eid_Paralysis = 42,
        eid_Constitution = 43,
        eid_Scaling = 44,
        eid_Endurance = 45,
        eid_Idle = 46,
        eid_RestoreMagic = 47,
        eid_RaiseMagic = 48,
        eid_Speedup = 49,
        eid_PoisonSpikeTrap = 50,
        eid_Quicksand = 51,
        eid_WaterTrap = 52,
        eid_StunGasTrap = 53,
        eid_PitTrap = 54,
        eid_DoorTrap = 55,
        eid_FireTrap = 56,
        eid_FrostTrap = 57,
        eid_LavaTrap = 58,
        eid_MonsterTrap = 59,
        eid_PhaseTrap = 60,
        eid_ArrowTrap = 61,
        eid_CrushRoofTrap = 62,
        eid_MistTrap = 63,
        eid_Dig = 64,
        eid_LocusMastery = 65,
        eid_Protection = 66,
        eid_Regeneration = 67,
        eid_ThirdSight = 68,
        eid_Imprisoning = 69,
        eid_Extinction = 70,
        eid_Knowledge = 71,
        eid_Enchantment = 72,
        eid_Recharging = 73,
        eid_Recall = 74,
        eid_Wonder = 75,
        eid_Alliance = 76,
        eid_Summoning = 77,
        eid_Identify = 78,
        eid_TwelveGates = 79,
        eid_TimeStop = 80,
        eid_Flame = 81,
        eid_TrapGeneration = 82,
        eid_LavaStrike = 83,
        eid_PureEvil = 84,
        eid_Diary = 85,
        eid_SwitchBodies = 86,
        eid_Geology = 87,
        eid_Diagnosis = 88,
        eid_Music = 89,
        eid_Animation = 90,
        eid_SwitchDimension = 91,
        eid_Transformation = 92,
        eid_Precognition = 93,
        eid_Mystery = 94,
        eid_Heat = 95,
        eid_Fire = 96,
        eid_Ice = 97,
        eid_Armoring = 98,
        eid_Displacement = 99,
        eid_Healing = 100,
        eid_Deanimation = 101,
        eid_Sleep = 102,
        eid_Cancellation = 103,
        eid_Polymorph = 104,
        eid_Restoration = 105,
        eid_Stoning = 106,
        eid_Light = 107,
        eid_Wishing = 108,
        eid_Evocation = 109,
        eid_Flaying = 110,
        eid_TrapDetection = 111,
        eid_Transmutation = 112,
        eid_Amusement = 113,
        eid_Wands = 114,
        eid_Death = 115,
        eid_Tunneling = 116,
        eid_Annihilation = 117,
        eid_Hastening = 118,
        eid_Chaos = 119,
        eid_Phase = 120,
        eid_SetRecall = 121,
        eid_IllusorySelf = 122,
        eid_Reflect = 123,
        eid_Entomb = 124,
        eid_DrawLife = 125,
        eid_Infravision = 126,
        eid_Might = 127,
        eid_Eternal_Life = 128,
        eid_SoulTrapping = 129,
        eid_Ashes = 130,
        eid_Insulation = 131,
        eid_Immunity = 132,
        eid_CrystalSkin = 133,
        eid_ChangeAbility = 134,
        eid_ChangeSkill = 135,
        eid_Basilisk_Poison = 136,
        eid_Borgonvile_Cloud = 137,
        eid_Breleor_Tendril = 138,
        eid_Ellegiant_Throw = 139,
        eid_Ellegiant_Crush = 140,
        eid_Firedragon_Breath = 141,
        eid_Firegiant_Touch = 142,
        eid_Fyleisch_Cloud = 143,
        eid_Gasball_Explosion = 144,
        eid_Giantsquid_Crush = 145,
        eid_Glard_Poison = 146,
        eid_Hatchetfish_Teeth = 147,
        eid_Heldragon_Cloud = 148,
        eid_Hillgiant_Crush = 149,
        eid_Icedragon_Breath = 150,
        eid_Icesphere_Blast = 151,
        eid_Jagredin_Burning = 152,
        eid_Knellbird_Gaze = 153,
        eid_Kobold_Throw = 154,
        eid_Lowerdwarf_Throw = 155,
        eid_Moleman_Debris = 156,
        eid_Phantomasp_Poison = 157,
        eid_Pyrtaath_Throttle = 158,
        eid_Ramapith_FireTouch = 159,
        eid_Sandiff_Acid = 160,
        eid_Scyld_Breath = 161,
        eid_Scyld_Ray = 162,
        eid_Scyld_ShockWave = 163,
        eid_Sentinel_Gaze = 164,
        eid_Serpent_Poison = 165,
        eid_Shadow_Touch = 166,
        eid_Slinn_Gout = 167,
        eid_Spirit_Touch = 168,
        eid_Stunworm_Stun = 169,
        eid_Terrain_Burning = 170,
        eid_Warrior_Throw = 171,
        eid_Watcher_Gaze = 172,
        eid_WeirdFume_Acid = 173,
        eid_Womera_Throw = 174,
        eid_Wooddwarf_Throw = 175,
        eid_Wyvern_Breath = 176,
        eid_Zardon_PsiBlast = 177,
        eid_StrengthReduce = 178,
        eid_HPEnlarge = 179,
        eid_Insanity = 180,
        eid_ArrowMake = 181,
        eid_Embalming = 182,
        eid_GolemCreation = 183,
        eid_OcarinaUse = 184,
        eid_Writing = 185,
        eid_GrapplingHookUse = 186,
        eid_PickAxeUse = 187,
        eid_Husbandry = 188,
        eid_FireVision = 189,
        eid_Fennling = 190,
        eid_SlaveUse = 191,
        eid_Taming = 192,
        eid_Ventriloquism = 193,
        eid_MindControl = 194,
        eid_PsiBlast = 195,
        eid_Obedience = 196,
        eid_FluteUse = 197,
        eid_FoodEat = 198,
        eid_DisruptionHornUse = 199,
        eid_LazlulRopeUse = 200,
        eid_GjallUse = 201,
        eid_BlackGemUse = 202,
        eid_Lodestone = 203,
        eid_Cube = 204,
        eid_SpeedDown = 205,
        eid_CrushRoof = 206,
        eid_Flood = 207,
        eid_Skidbladnir = 208,
        eid_Sail = 209,
        eid_Dialog = 210,
        eid_FillVial = 211,
        eid_FireStorm = 212,
        eid_Winds = 213,
        eid_Prayer = 214,
        eid_Sacrifice = 215,
        eid_Ull_Gaze = 216,
        eid_RunicDivination = 217,
        eid_Swoon = 218,
        eid_Prowling = 219,
        eid_HurtleThroughTime = 220,
        eid_CaughtInNet = 221,

        /*
        sp_FireBolt,        // ОгненныйУдар
        sp_ThunderBolt,     // МолниейУдар
        sp_FrostBolt,
        sp_IceStorm,        // Ледяной шторм
        sp_Freeze,          // Замораживание
        sp_PoisonCloud,     // ОблакоЯда
    
        sp_Berserk,         // Берсерк
        sp_Slow,            // Замедление
        sp_Confuse,         // Спутывать
        sp_Blindness,       // Слепота
        sp_Poisoned,        // Отравление
        sp_Afraid,          // Испугать
        sp_Paralyzed,       // Паралич
        sp_Sleep,           // Усыпить
        sp_MeteorSwarm,
        //eid_DivineGrace       = 217, // Благодать    
        */

        eid_First = eid_None,
        eid_Last = eid_CaughtInNet
    }
}
