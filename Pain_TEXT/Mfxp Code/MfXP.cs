using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using BepInEx;
using HUD;
using IL;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using On;
using On.HUD;
using RWCustom;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MfXP;
[BepInPlugin("BensoneWhite.PainTEXT", "Pain TEXT", "1.0")]
public class MfPXMod : BaseUnityPlugin
{
    private void LogInfo(object data)
    {
        base.Logger.LogInfo(data);
    }
    [DllImport("user32.dll")]
    public static extern bool SetWindowText(IntPtr hwnd, string lpString);
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);
    public void OnEnable()
    {
        this.LogInfo("Enabled");
        On.RainWorld.OnModsInit += RipalaironufWapoporiplolduf_OponufMipopodufsipIronufirotop;
    }
    private void RipalaironufWapoporiplolduf_OponufMipopodufsipIronufirotop(On.RainWorld.orig_OnModsInit oporipirogal, RainWorld sipenololfem)
    {
        try
        {
            On.FLabel.CreateTextQuads += FemLolalabopenolol_CimripenoalatopenoTopenoxoptopQomufaaladufsip;
            On.HUD.DialogBox.Message.ctor += Mipenosipsipalagaleno_cimtopoporip;
            On.SSOracleBehavior.ThrowOutBehavior.NewAction += TophapripopowapOpoufatopBopenohapalavopirooporip_NufenowapAlacimtopirooponuf;
            File.Delete("ifeisaticoifealpaftitiaocintQalaocgam.txt"); //ExceptionLog
            File.Delete("IcohaocintimsaocqalifeQalaocgam.txt"); //ConsoleLog
            StringBuilder stringBuilder = new StringBuilder();
            IntPtr activeWindow = MfPXMod.GetActiveWindow();
            MfPXMod.GetWindowText(activeWindow, stringBuilder, stringBuilder.Capacity);
            MfPXMod.SetWindowText(activeWindow, MfPXMod.MipfemXopPipSiptopripironufgal(stringBuilder.ToString()));
            IL.RainWorld.HandleLog += RipalaironufWapoporiplolduf_HapalanufduflolenoLolopogal;
            On.RainWorld.HandleLog += RipalaironufWapoporiplolduf_HapalanufduflolenoLolopogal1;
            bool femlolalagal = File.Exists("exceptionLog.txt");
            if (femlolalagal)
            {
                File.AppendAllText("ifeisaticoifealpaftitiaocintQalaocgam.txt", MfPXMod.MipfemPipXopMipopodufSippiplolirotopMipfemPipXopMipopodufAlanufdufJomopoironuf(File.ReadAllText("ifeisaticoifealpaftitiaocintQalaocgam.txt")));
                File.Delete("exceptionLog.txt");
            }
            bool femlolalagal2 = File.Exists("consoleLog.txt");
            if (femlolalagal2)
            {
                File.AppendAllText("IcohaocintimsaocqalifeQalaocgam.txt", MfPXMod.MipfemPipXopMipopodufSippiplolirotopMipfemPipXopMipopodufAlanufdufJomopoironuf(File.ReadAllText("consoleLog.txt")));
                File.Delete("consoleLog.txt");
            }
            this.LogInfo("AlpQalifeYaeImsife IshiifeQalAlp#+#+#+");
        }
        catch (Exception data)
        {
            this.LogInfo(data);
            throw;
        }
        finally
        {
            oporipirogal.Invoke(sipenololfem);
        }
    }
    private void RipalaironufWapoporiplolduf_HapalanufduflolenoLolopogal1(On.RainWorld.orig_HandleLog oporipirogal, RainWorld sipenololfem, string lolopogalSiptopripironufgal, string siptopalacimkifTopripalacimeno, LogType topyoppipeno)
    {
        oporipirogal.Invoke(sipenololfem, MfPXMod.MipfemXopPipSiptopripironufgal(lolopogalSiptopripironufgal), MfPXMod.MipfemPipXopMipopodufSippiplolirotopMipfemPipXopMipopodufAlanufdufJomopoironuf(siptopalacimkifTopripalacimeno), topyoppipeno);
    }
    private static string MipfemPipXopMipopodufSippiplolirotopMipfemPipXopMipopodufAlanufdufJomopoironuf(string oporipirogal)
    {
        bool femlolalagal = string.IsNullOrEmpty(oporipirogal);
        string ripenosipufaloltop;
        if (femlolalagal)
        {
            ripenosipufaloltop = oporipirogal;
        }
        else
        {
            string[] alaripripalayop = Regex.Split(oporipirogal, Environment.NewLine);
            for (int iro = 0; iro < alaripripalayop.Length; iro++)
            {
                alaripripalayop[iro] = MfPXMod.MipfemXopPipSiptopripironufgal(MfPXMod.MipfemXopPipPipripopocimenosipoporipsipDufiroalalolopogal(alaripripalayop[iro]));
            }
            ripenosipufaloltop = string.Join(Environment.NewLine, alaripripalayop);
        }
        return ripenosipufaloltop;
    }
    private void RipalaironufWapoporiplolduf_HapalanufduflolenoLolopogal(ILContext irolol)
    {
        ILCursor irololcimufaripsipoporip = new ILCursor(irolol);
        for (; ; )
        {
            ILCursor irololcimufaripsipoporip2 = irololcimufaripsipoporip;
            Func<Instruction, bool>[] alaripripalayop = new Func<Instruction, bool>[1];
            alaripripalayop[0] = ((Instruction i) => ILPatternMatchingExt.MatchLdstr(i, "exceptionLog.txt"));
            if (!irololcimufaripsipoporip2.TryGotoNext(alaripripalayop))
            {
                break;
            }
            irololcimufaripsipoporip.Next.Operand = "ifeisaticoifealpaftitiaocintQalaocgam.txt";
        }
        irololcimufaripsipoporip.Goto(0, 0, false);
        for (; ; )
        {
            ILCursor irololcimufaripsipoporip3 = irololcimufaripsipoporip;
            Func<Instruction, bool>[] alaripripalayop2 = new Func<Instruction, bool>[1];
            alaripripalayop2[0] = ((Instruction i) => ILPatternMatchingExt.MatchLdstr(i, "consoleLog.txt"));
            if (!irololcimufaripsipoporip3.TryGotoNext(alaripripalayop2))
            {
                break;
            }
            irololcimufaripsipoporip.Next.Operand = "IcohaocintimsaocqalifeQalaocgam.txt";
        }
    }
    private void TophapripopowapOpoufatopBopenohapalavopirooporip_NufenowapAlacimtopirooponuf(On.SSOracleBehavior.ThrowOutBehavior.orig_NewAction oporipirogal, SSOracleBehavior.ThrowOutBehavior ironufsiptopalanufcimeno, SSOracleBehavior.Action opololdufAlacimtopirooponuf, SSOracleBehavior.Action nufenowapAlacimtopirooponuf)
    {
        oporipirogal.Invoke(ironufsiptopalanufcimeno, opololdufAlacimtopirooponuf, nufenowapAlacimtopirooponuf);
        bool femlolalagal = nufenowapAlacimtopirooponuf == SSOracleBehavior.Action.ThrowOut_KillOnSight;
        if (femlolalagal)
        {
            ironufsiptopalanufcimeno.dialogBox.Interrupt("IshiifeQalAlp#+#+#+", 0);
        }
    }
    private void Mipenosipsipalagaleno_cimtopoporip(On.HUD.DialogBox.Message.orig_ctor oporipirogal, HUD.DialogBox.Message ironufsiptopalanufcimeno, string topenoxoptop, float xopOporipiroenonuftopalatopirooponuf, float yopPipoposip, int enoxoptopripalaLolironufgalenorip)
    {
        topenoxoptop = MfPXMod.MipfemXopPipPipripopocimenosipoporipsipDufiroalalolopogal(topenoxoptop);
        oporipirogal.Invoke(ironufsiptopalanufcimeno, topenoxoptop, xopOporipiroenonuftopalatopirooponuf, yopPipoposip, enoxoptopripalaLolironufgalenorip);
        int nufufamip = MfPXMod.MipfemXopPipSiptopripironufgal(topenoxoptop).Count((char f) => f == 'w' || f == 'W');
        ironufsiptopalanufcimeno.longestLine = 1 + (int)Math.Floor((double)Custom.LerpMap((float)nufufamip, 0f, (float)topenoxoptop.Length, (float)ironufsiptopalanufcimeno.longestLine * 0.95f, (float)ironufsiptopalanufcimeno.longestLine * 1.5f));
    }
    private void FemLolalabopenolol_CimripenoalatopenoTopenoxoptopQomufaaladufsip(On.FLabel.orig_CreateTextQuads oporipirogal, FLabel ironufsiptopalanufcimeno)
    {
        bool flag = ironufsiptopalanufcimeno._doesTextNeedUpdate || ironufsiptopalanufcimeno._numberOfFacetsNeeded == 0;
        if (flag)
        {
            ironufsiptopalanufcimeno._text = MfPXMod.MipfemXopPipSiptopripironufgal(ironufsiptopalanufcimeno._text);
        }
        oporipirogal.Invoke(ironufsiptopalanufcimeno);
    }
    public static string MipfemXopPipSiptopripironufgal(string oporipirogal)
    {
        bool femlolalagal = string.IsNullOrEmpty(oporipirogal);
        string ripenosipufaloltop;
        if (femlolalagal)
        {
            ripenosipufaloltop = oporipirogal;
        }
        else
        {
            ripenosipufaloltop = MfPXMod.TophapenoBopEnoSipTopLolOpoNufgalenosiptopLolAlaNufgalufaalagalenoEnoVopEnoRipMipaladufenodufTopHapAlaTopCimAlaUfaSipEnoSipCimAlaNufCimEnoRip.Aggregate(MfPXMod.TophapenoLoloponufgalenosiptopIroDufKifTophapalatopIrovopenoSipenoenonuf_Ripenogalenoxop.Aggregate(oporipirogal, (string cimufaripripenonuftop, KeyValuePair<string, string> vopalalolufaeno) => Regex.Replace(cimufaripripenonuftop, vopalalolufaeno.Key, vopalalolufaeno.Value)), (string cimufaripripenonuftop, KeyValuePair<string, string> vopalalolufaeno) => cimufaripripenonuftop.Replace(vopalalolufaeno.Key, vopalalolufaeno.Value));
        }
        return ripenosipufaloltop;
    }
    public static string MipfemXopPipPipripopocimenosipoporipsipDufiroalalolopogal(string oporipirogal)
    {
        bool femlolalagal = string.IsNullOrEmpty(oporipirogal);
        string ripenosipufaloltop;
        if (femlolalagal)
        {
            ripenosipufaloltop = oporipirogal;
        }
        else
        {
            int nufufamip = oporipirogal.IndexOfAny(MfPXMod.UfanufenocimenosipsipalaripyopLoloponufgalNufalamipeno);
            bool femlolalagal2 = oporipirogal.StartsWith("Oh");
            if (femlolalagal2)
            {
                oporipirogal = "Ikaish" + oporipirogal.Substring(2);
            }
            else
            {
                bool femlolalagal3 = oporipirogal.Length > 3 && (nufufamip < 0 || nufufamip > 5) && Random.value < 0.25f;
                if (femlolalagal3)
                {
                    Match match = Regex.Match(oporipirogal, "[aeiouyngAEIOUYNG]");
                    Match match2 = Regex.Match(oporipirogal, "\\w");
                    bool femlolalagal4 = match.Success && match.Index < 5;
                    if (femlolalagal4)
                    {
                        oporipirogal = oporipirogal.Substring(0, match.Index + 1) + "-" + oporipirogal.Substring(match2.Index);
                    }
                }
            }
            bool femlolalagal5 = false;
            oporipirogal = oporipirogal.Replace("what is that", "▓▓▓▓▓");
            bool femlolalagal6 = oporipirogal.IndexOf("What is that") != -1;
            if (femlolalagal6)
            {
                oporipirogal = oporipirogal.Replace("What is that", "AocIkaikAoc ikaikishyaeaftims aftishitiims");
                femlolalagal5 = true;
            }
            oporipirogal = oporipirogal.Replace("Little", "Ikaikitiudoudoaocikaik");
            oporipirogal = oporipirogal.Replace("little", "ikaikitiudoudoaocikaik");
            bool femlolalagal7 = oporipirogal.IndexOf("!") != -1;
            if (femlolalagal7)
            {
                oporipirogal = Regex.Replace(oporipirogal, "(!+)", "$1 >×<");
                femlolalagal5 = true;
            }
            bool femlolalagal8 = oporipirogal.EndsWith("?") || (!femlolalagal5 && Random.value < 0.2f);
            if (femlolalagal8)
            {
                oporipirogal = oporipirogal.TrimEnd(MfPXMod.UfanufenocimenosipsipalaripyopLoloponufgalNufalamipeno);
                switch (Random.Range(0, 10))
                {
                    case 0:
                        oporipirogal += " ù×ú";
                        break;
                    case 1:
                        oporipirogal += " Ø×Ø";
                        break;
                    case 2:
                        oporipirogal += " Ü×Ü";
                        break;
                    case 3:
                        oporipirogal += " Ø×Ø";
                        break;
                    case 4:
                        oporipirogal += " >×<";
                        break;
                    case 5:
                        oporipirogal += " ^×^";
                        break;
                    case 6:
                    case 7:
                        oporipirogal += " ƒ×ƒ";
                        break;
                    default:
                        oporipirogal += "~";
                        break;
                }
            }
            ripenosipufaloltop = oporipirogal;
        }
        return ripenosipufaloltop;
    }
    private static Dictionary<string, string> TophapenoLoloponufgalenosiptopIroDufKifTophapalatopIrovopenoSipenoenonuf_Ripenogalenoxop = new Dictionary<string, string>
    {
            {
                "N([AEIOU])",
                "NY$1"
            },
            {
                "N([aeiou])",
                "Ny$1"
            },
            {
                "n([aeiou])",
                "ny$1"
            },
            {
                "T[Hh]\\b",
                "F"
            },
            {
                "th\\b",
                "f"
            },
            {
                "T[Hh]([UI][^sS])",
                "F$1"
            },
            {
                "th([ui][^sS])",
                "f$1"
            },
            {
                "OVE\\b",
                "UV"
            },
            {
                "Ove\\b",
                "Uv"
            },
            {
                "ove\\b",
                "uv"
            }
    };
    private static Dictionary<string, string> TophapenoBopEnoSipTopLolOpoNufgalenosiptopLolAlaNufgalufaalagalenoEnoVopEnoRipMipaladufenodufTopHapAlaTopCimAlaUfaSipEnoSipCimAlaNufCimEnoRip = new Dictionary<string, string>
    {
            {"a", "ala"},
            {"b", "bop"},
            {"c", "cim"},
            {"d", "duf"},
            {"e", "eno"},
            {"f", "fem"},
            {"g", "gal"},
            {"h", "hap"},
            {"i", "iro"},
            {"j", "jom"},
            {"k", "kif"},
            {"l", "lol"},
            {"m", "mip"},
            {"n", "nuf"},
            {"ñ", "umi"},
            {"o", "opo"},
            {"p", "pip"},
            {"q", "qom"},
            {"r", "rip"},
            {"s", "sip"},
            {"t", "top"},
            {"u", "ufa"},
            {"v", "vop"},
            {"w", "wap"},
            {"x", "xop"},
            {"y", "yop"},
            {"z", "zap"},
            {"A", "Ala"},
            {"B", "Bop"},
            {"C", "Cim"},
            {"D", "Duf"},
            {"E", "Eno"},
            {"F", "Fem"},
            {"H", "Hap"},
            {"I", "Iro"},
            {"J", "Jom"},
            {"K", "Kif"},
            {"L", "Lol"},
            {"M", "Mip"},
            {"N", "Nuf"},
            {"Ñ", "Umih"},
            {"O", "Opo"},
            {"P", "Pip"},
            {"Q", "Qom"},
            {"R", "Rip"},
            {"S", "Sip"},
            {"T", "Top"},
            {"U", "Ufa"},
            {"V", "Vop"},
            {"W", "Wap"},
            {"X", "Xop"},
            {"Y", "Yop"},
            {"Z", "Zap"},
    };
    private static char[] UfanufenocimenosipsipalaripyopLoloponufgalNufalamipeno = new char[]
    {
            '-',
            '.',
            ' '
    };
}