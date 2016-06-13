' Projekt Akiha copyright notice. © 2015, 16 Doqtor Kirby.

' Melee Toolbox Extended (Projekt Akiha) is free software licensed under the
' GNU General Public License version 3. There is a file called COPYING on the
' GitHub repository, and copying.txt in the release packages.
' Projekt Akiha comes with NO WARRANTY, even those implied ones of merchantability
' or fitness for a particular purpose.

Module Akiha

    Sub Main(ByVal cmdArgs() As String)
        Dim mtbver = "4.5"
        Dim compiledate = "12 June 2016 23:37"
        Dim mc = My.Computer
        Dim nl = Environment.NewLine
        Console.SetWindowSize(80, 25)
        Console.SetBufferSize(80, 500)
        REM 012345678901234567890123456789012345678901234567890123457890123456789012345678901
        Console.WriteLine(nl +
"        __  ___    __          ______          ____              ____   ____" + nl +
"       /  |/  /__ / /__ ___   /_  __/__  ___  / / /  ___ __ __  / / /  / __/" + nl +
"      / /|_/ / -_) / -_) -_)   / / / _ \/ _ \/ / _ \/ _ \\ \ / /_  _/ /__ \" + nl +
"     /_/  /_/\__/_/\__/\__/   /_/  \___/\___/_/_.__/\___/_\_\   /_/(_)____/" + nl +
"                           Melee Toolbox Extended " + mtbver + nl +
"                                by Doqtor Kirby" + nl)
        If cmdArgs.Length > 0 Then
            For argNum As Integer = 0 To UBound(cmdArgs, 1)
                REM Console.WriteLine("debug: " + cmdArgs(0) + " " + cmdArgs(1))
                If cmdArgs(0) = "-c" Then
                    GoTo mtbcommands
                ElseIf cmdArgs(0) = "update" Then
                    GoTo appupdate
                Else
                    GoTo Applaunch
                End If
            Next
        Else
            Console.WriteLine("  Syntax:" + nl +
            "  mtbx [appname]" + nl +
            "  mtbx -c [command]" + nl +
            "  mtbx update [appname]" + nl + nl +
            "  Application list:" + nl +
            "  hps_insert ssmex hpsauto vgmstream meleehps meleessm dtw png2tpl toolkit" + nl +
            "  toolbox texfind kirbytool vertconv umc mcm asmwiird crazyhand dolphin" + nl +
            "  dolphindbg gcr hxd ssbmver neko efchg laschg thpplay mth_make 20xxmm mac" + nl +
            "  d2hgui" + nl + nl +
            "  Toolbox Commands:" + nl + nl +
            "  ver version github copyright license")
            End
        End If
        End
Applaunch:
        If cmdArgs(0) = "hps_insert" Then
            On Error GoTo appnotfound
            Process.Start("lib\hps_insert.bat")
            Console.WriteLine("  Launching hps_insert...")
            End
        ElseIf cmdArgs(0) = "ssmex" Then
            On Error GoTo appnotfound
            Process.Start("lib\ssmex.bat")
            Console.WriteLine("  Launching ssmex...")
            End
        ElseIf cmdArgs(0) = "hpsauto" Then
            On Error GoTo appnotfound
            Process.Start("lib\hpsauto.exe")
            Console.WriteLine("  Launching HPSAuto...")
            End
        ElseIf cmdArgs(0) = "vgmstream" Then
            On Error GoTo appnotfound
            Process.Start("lib\vgmstream.bat")
            Console.WriteLine("  Launching vgmstream...")
            End
        ElseIf cmdArgs(0) = "meleehps" Then
            On Error GoTo appnotfound
            Process.Start("notepad lib\hps\main.asm")
            Console.WriteLine("  Launching editor for MeleeHPS...")
            Console.WriteLine("  Don't forget to save. Press Start to compile.")
            Console.Read()
            Console.WriteLine("  Launching MeleeHPS...")
            Process.Start("lib\hps\ASM68K.exe")
            End
        ElseIf cmdArgs(0) = "meleessm" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching editor for MeleeSSM...")
            Process.Start("notepad lib\ssm\main.asm")
            Console.WriteLine("  Don't forget to save. Press Start to compile.")
            Console.Read()
            Console.WriteLine("  Launching MeleeSSM...")
            Process.Start("lib\ssm\ASM68K.exe")
            End
        ElseIf cmdArgs(0) = "dtw" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching DAT Texture Wizard...")
            Process.Start("lib\dtw\DAT Texture Wizard.exe")
            End
        ElseIf cmdArgs(0) = "png2tpl" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching PNG to-from TPL...")
            Process.Start("lib\ptt\PNG to-from TPL.bat")
            End
        ElseIf cmdArgs(0) = "toolkit" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Melee Toolkit...")
            Process.Start("lib\MeleeToolkit.exe")
            End
        ElseIf cmdArgs(0) = "toolbox" Then
            Console.WriteLine("  Ha ha. Funny. This is the Melee Toolbox, baka.")
            End
        ElseIf cmdArgs(0) = "texfind" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Texture Finder...")
            Process.Start("lib\TextureFinder.exe")
            End
        ElseIf cmdArgs(0) = "kirbytool" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching KirbyTool...")
            Process.Start("lib\ktool\")
            End
        ElseIf cmdArgs(0) = "vertconv" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching VertConvert...")
            Process.Start("lib\vertconvert.exe")
            End
        ElseIf cmdArgs(0) = "umc" Then
            Console.WriteLine("  Unsupported in current version.")
            End
        ElseIf cmdArgs(0) = "mcm" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Melee Code Manager...")
            Process.Start("lib\mcm\Melee Code Manager.exe")
            End
        ElseIf cmdArgs(0) = "asmwiird" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching ASMWiiRD...")
            Process.Start("lib\gdnet\asmwiird.exe")
            End
        ElseIf cmdArgs(0) = "crazyhand" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Crazy Hand...")
            Process.Start("lib\chand\CHAND.bat")
            End
        ElseIf cmdArgs(0) = "dolphin" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Dolphin...")
            Process.Start("lib\Dolphin\Dolphin.exe")
            End
        ElseIf cmdArgs(0) = "dolphindbg" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Dolphin DebugFast...")
            Process.Start("lib\dolphindf\dolphin.exe /d")
            End
        ElseIf cmdArgs(0) = "dolphindf" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Dolphin DebugFast...")
            Process.Start("lib\dolphindf\dolphin.exe /d")
            End
        ElseIf cmdArgs(0) = "gcr" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching GCRebuilder...")
            Process.Start("lib\gcr.exe")
            End
        ElseIf cmdArgs(0) = "hxd" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching HxD...")
            Process.Start("lib\hxd.exe")
            End
        ElseIf cmdArgs(0) = "ssbmver" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching SSBM Version Patcher...")
            Process.Start("lib\versionpatch\SSBM_patch.exe")
            End
        ElseIf cmdArgs(0) = "neko" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Melee Toolbox 4.0 does not support any version of Projekt Neko." + nl +
                              "  See 'mtbx len' for Projekt Neko's replacement [Projekt Len].")
            REM Process.Start("lib\pn.exe")
            End
        ElseIf cmdArgs(0) = "efchg" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Effect Changer...")
            Process.Start("lib\EffectChanger.exe")
            End
        ElseIf cmdArgs(0) = "effects" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Effect Changer...")
            Process.Start("lib\EffectChanger.exe")
            End
        ElseIf cmdArgs(0) = "laschg" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Laser Changer...")
            Process.Start("lib\LaserChanger.exe")
            End
        ElseIf cmdArgs(0) = "lasers" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Laser Changer...")
            Process.Start("lib\LaserChanger.exe")
            End
        ElseIf cmdArgs(0) = "thpplay" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching thpplay...")
            Process.Start("lib\thpplay.exe")
            End
        ElseIf cmdArgs(0) = "mth_make" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching mth_make...")
            Process.Start("lib\mth_make.bat")
            End
        ElseIf cmdArgs(0) = "mthmake" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching mth_make...")
            Process.Start("lib\mth_make.bat")
            End
        ElseIf cmdArgs(0) = "20xxmm" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching 20XX Music Manager...")
            Process.Start("lib\20xxmm\20XX Music Manager.jar")
            End
        ElseIf cmdArgs(0) = "len" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Projekt Len...")
            Process.Start("lib\len\Projekt Len.exe")
            End
        ElseIf cmdArgs(0) = "mac" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching Melee Audio Converter...")
            Process.Start("lib\Melee Audio Converter.jar")
            End
        ElseIf cmdArgs(0) = "d2hgui" Then
            On Error GoTo appnotfound
            Console.WriteLine("  Launching d2hgui...")
            Process.Start("lib\d2hgui.exe")
            End
            Else
            Console.WriteLine("  Didn't understand that. For a commands list, type 'mtbx'.")
            End
        End If
        End
appupdate:
        For argNum As Integer = 0 To UBound(cmdArgs, 1)
            On Error GoTo updatewhat
            REM Console.WriteLine("debug: " + cmdArgs(0) + " " + cmdArgs(1))
            Dim mtbapp As String = cmdArgs(1)
            If cmdArgs(1) IsNot Nothing Then
                On Error GoTo updatefail
                Console.WriteLine("  Updating " + mtbapp + "...")
                mc.Network.DownloadFile("http://portland.refreshnet.co.uk/toolbox/" + mtbapp + ".7z", "dl\" + mtbapp + ".7z")
                Using mtbupdate As New Process
                    mtbupdate.StartInfo.Arguments = "x -aoa -y dl\" + mtbapp + ".7z"
                    mtbupdate.StartInfo.FileName = "\lib\7z.exe"
                    mtbupdate.Start()
                    mtbupdate.WaitForExit()
                End Using
                mc.FileSystem.DeleteFile("dl\hps_insert.7z")
                Console.WriteLine("  Done.")
                End
            End If
            If cmdArgs(1) Is Nothing Then
updatewhat:
                Console.WriteLine("  Update what? (you didn't specify an app)")
                End
            End If
            End
        Next
        End
updatefail:
        Console.WriteLine("  Application '" + cmdArgs(1) + "' couldn't be downloaded. Check your internet connection " + nl +
                          "  and command spelling.")
        End
appnotfound:
        Console.WriteLine("  Application " + cmdArgs(0) + " not found. Try running 'mtbx update " + cmdArgs(0) + "'.")
        End
mtbcommands:
        For argNum As Integer = 0 To UBound(cmdArgs, 1)
            REM Console.WriteLine("debug: " + cmdArgs(0) + " " + cmdArgs(1))
            If cmdArgs(1) = "version" Then
                Console.WriteLine("  This is version " + mtbver + ", compiled on " + compiledate)
                End
            ElseIf cmdArgs(1) = "ver" Then
                Console.WriteLine("  This is version " + mtbver + ", compiled on " + compiledate)
                End
            ElseIf cmdArgs(1) = "github" Then
                Console.WriteLine("  GitHub: http://www.github.com/doqtorkirby/akiha")
                End
            ElseIf cmdArgs(1) = "copyright" Then
                Console.WriteLine("  Melee Toolbox is copyright (c) 2015-16 Doqtor Kirby")
                Console.WriteLine("  Melee Toolbox is licensed under the terms of the GNU General Public")
                Console.WriteLine("  License Version 3 or, at your convenience, any later version.")
                Console.WriteLine("")
                Console.WriteLine("  Melee Toolbox is provided in the hopes that it will be useful, but")
                Console.WriteLine("  contains NO WARRANTY of any kind. Not even the implied warranties of")
                Console.WriteLine("  merchantability or fitness for a particular purpose.")
                Console.WriteLine("")
                Console.WriteLine("  See 'mtbx -c license' for the terms of the GPLv3.")
                End
            ElseIf cmdArgs(1) = "license" Then
                Process.Start("copying.txt")
                End
            Else
                Console.WriteLine("  Didn't understand that. For a commands list, type 'mtbx'.")
                End
            End If
        Next
        End
    End Sub
End Module
