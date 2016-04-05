Module Module1

    Sub Main()
        Dim mtbver = "4.0"
        Dim app As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        Console.WriteLine("")
        Console.WriteLine("  Melee Toolbox " & mtbver)
        Console.WriteLine("  by Doqtor Kirby")
        Console.WriteLine("")
        If app IsNot Nothing Then
            GoTo Applaunch
        End If
        Console.WriteLine("  Application list [start with mtb appname]")
        Console.WriteLine("  hps_insert ssmex hpsauto vgmstream meleehps meleessm dtw png2tpl toolkit")
        Console.WriteLine("  toolbox texfind kirbytool vertconv umc mcm asmwiird crazyhand dolphin")
        Console.WriteLine("  dolphindbg gcr hxd ssbmver neko efchg laschg thpplay mth_make")
        Console.WriteLine("")
        End
Applaunch:
        Applaunch()
    End Sub

    Sub Applaunch()
        Dim app As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        If app Is "hps_insert" Then
            Process.Start("lib\hps_insert.bat")
        End If
        If app Is "ssmex" Then
            Process.Start("lib\ssmex.bat")
        End If
        If app Is "hpsauto" Then
            Process.Start("lib\hpsauto.exe")
        End If

    End Sub

End Module
