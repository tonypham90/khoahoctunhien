using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Services;

namespace WebApplication2.Pages;

public class MH_Cong2ps : PageModel
{
    public PhanSo A { get; set; }
    public PhanSo B { get; set; }
    public string text { get; set; }
    [BindProperty] // bao nhieu thong so bay nhieu bindproperty
    public int tua { get; set; }
    [BindProperty]
    public int maua { get; set; }
    [BindProperty]
    public int tub { get; set; }
    [BindProperty]
    public int maub { get; set; }

    public void OnGet()
    {
        text = String.Empty;
    }

    public void OnPost()
    {
        PhanSo A = new PhanSo();
        PhanSo B = new PhanSo();
        A.TuSo = tua;
        A.MauSo = maua;
        B.TuSo = tub;
        B.MauSo = maub;
        PhanSo so = XuLyPhanSo.TongPhanSo(A, B);
        text = $"Ket qua tong 2 phan so la {so.TuSo}/{so.MauSo}";

    }
}