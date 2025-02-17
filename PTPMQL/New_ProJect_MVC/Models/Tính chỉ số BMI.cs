namespace New_ProJect_MVC.Models;
public class TinhChiSoBMI
{
    public string CanNang { get; set; }
    public string ChieuCao { get; set; }

    public string TinhBMI (string CanNang, string ChieuCao)
    {
        CanNang = cannang;
        ChieuCao = chieucao;
    }
        if (ChieuCao <=0) return 0;
        return CanNang / ( ChieuCao * CanNang);
    }
}
