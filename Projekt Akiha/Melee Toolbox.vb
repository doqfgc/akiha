Module Akiha

    Sub Main(ByVal cmdArgs() As String)
        Dim mtbver = "4.0"
        Console.SetWindowSize(80, 25)
        Console.SetBufferSize(80, 500)
        REM 012345678901234567890123456789012345678901234567890123457890123456789012345678901
        Console.WriteLine(Environment.NewLine +
"        __  ___    __          ______          ____              ____  ___" + Environment.NewLine +
"       /  |/  /__ / /__ ___   /_  __/__  ___  / / /  ___ __ __  / / / / _ \" + Environment.NewLine +
"      / /|_/ / -_) / -_) -_)   / / / _ \/ _ \/ / _ \/ _ \\ \ / /_  _// // /" + Environment.NewLine +
"     /_/  /_/\__/_/\__/\__/   /_/  \___/\___/_/_.__/\___/_\_\   /_/(_)___/" + Environment.NewLine +
"                           Melee Toolbox Extended " + mtbver + Environment.NewLine +
"                                by Doqtor Kirby" + Environment.NewLine)
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
            Console.WriteLine("  Syntax:" + Environment.NewLine +
            "  mtbx [appname]" + Environment.NewLine +
            "  mtbx -c [command]" + Environment.NewLine +
            "  mtbx update [appname]" + Environment.NewLine + Environment.NewLine +
            "  Application list:" + Environment.NewLine +
            "  hps_insert ssmex hpsauto vgmstream meleehps meleessm dtw png2tpl toolkit" + Environment.NewLine +
            "  toolbox texfind kirbytool vertconv umc mcm asmwiird crazyhand dolphin" + Environment.NewLine +
            "  dolphindbg gcr hxd ssbmver neko efchg laschg thpplay mth_make" + Environment.NewLine + Environment.NewLine +
            "  Toolbox Commands:" + Environment.NewLine + Environment.NewLine +
            "  ver version github copyright license")
            End
        End If
        End
Applaunch:
        If cmdArgs(0) = "hps_insert" Then
            Process.Start("lib\hps_insert.bat")
            End
        ElseIf cmdArgs(0) = "ssmex" Then
            Process.Start("lib\ssmex.bat")
            End
        ElseIf cmdArgs(0) = "hpsauto" Then
            Process.Start("lib\hpsauto.exe")
            End
        ElseIf cmdArgs(0) = "vgmstream" Then
            Process.Start("lib\vgmstream.bat")
            End
        ElseIf cmdArgs(0) = "meleehps" Then
            Process.Start("notepad lib\hps\main.asm")
            Console.WriteLine("  Don't forget to save. Press Start to compile.")
            Console.Read()
            Process.Start("lib\hps\ASM68K.exe")
            End
        ElseIf cmdArgs(0) = "meleessm" Then
            Process.Start("notepad lib\ssm\main.asm")
            Console.WriteLine("  Don't forget to save. Press Start to compile.")
            Console.Read()
            Process.Start("lib\ssm\ASM68K.exe")
            End
        ElseIf cmdArgs(0) = "dtw" Then
            Process.Start("lib\dtw\DAT Texture Wizard.exe")
            End
        ElseIf cmdArgs(0) = "png2tpl" Then
            Process.Start("lib\ptt\PNG to-from TPL.bat")
            End
        ElseIf cmdArgs(0) = "toolkit" Then
            Process.Start("lib\MeleeToolkit.exe")
            End
        ElseIf cmdArgs(0) = "toolbox" Then
            Console.WriteLine("  Ha ha. Funny. This is the Melee Toolbox, baka.")
            End
        ElseIf cmdArgs(0) = "texfind" Then
            Process.Start("lib\TextureFinder.exe")
            End
        End If
        End
appupdate:
        End
mtbcommands:
        For argNum As Integer = 0 To UBound(cmdArgs, 1)
            REM Console.WriteLine("debug: " + cmdArgs(0) + " " + cmdArgs(1))
            If cmdArgs(1) = "ver" Or "version" Then
                Console.WriteLine("  This is version " + mtbver + ", compiled on " + DateString)
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
