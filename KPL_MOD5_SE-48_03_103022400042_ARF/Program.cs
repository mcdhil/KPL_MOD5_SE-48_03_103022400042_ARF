using KPL_MOD5_SE_48_03_103022400042_ARF;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======= Pungujian table Driven (kode paket)======");
        KodePaket kodePaket = new KodePaket();
        Console.WriteLine($"kode untuk paket premium: {kodePaket.getKodePaket("premium")}");
        Console.WriteLine($"kode untuk paket student: {kodePaket.getKodePaket("student")}");
        Console.WriteLine($"kode untuk paket unlimited: {kodePaket.getKodePaket("unlimited")}");
    
        Console.WriteLine("\n======= Pungujian state based (mesin kopi)======");
        MesinKopi mesinKopi = new MesinKopi();
        mesinKopi.TriggerState(MesinKopi.Trigger.POWER_ON);
        mesinKopi.TriggerState(MesinKopi.Trigger.START_BREWING);
        mesinKopi.TriggerState(MesinKopi.Trigger.FINISH_BREWING); 
        mesinKopi.TriggerState(MesinKopi.Trigger.START_MAINTENANCE);
        mesinKopi.TriggerState(MesinKopi.Trigger.FINISH_MAINTENANCE);

        mesinKopi.TriggerState(MesinKopi.Trigger.START_BREWING);
        mesinKopi.TriggerState(MesinKopi.Trigger.POWER_ON);

        mesinKopi.TriggerState(MesinKopi.Trigger.FINISH_BREWING);
        mesinKopi.TriggerState(MesinKopi.Trigger.POWER_OFF);
    }
}