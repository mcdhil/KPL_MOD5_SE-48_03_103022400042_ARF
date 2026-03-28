using System;
using System.Collections.Generic;
using System.Text;

namespace KPL_MOD5_SE_48_03_103022400042_ARF

public class KodePaket { 
    public string getKodePaket(string namaPaket)
    {
        string[] nama = { "basic", "standard", "premium" , "unlimitid", "gaming", "streaming", "family", "business", "student", "traveler"};
        string[] kode = { "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210" };

        for (int i = 0; i < nama.Length; i++)
        {
            if (nama[i] == namaPaket)
            {
                return kode[i];
            }
        }
        return "Kode paket tidak ditemukan";
    }

}
