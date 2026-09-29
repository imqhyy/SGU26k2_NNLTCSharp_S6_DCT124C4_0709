using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ;

class Program
{
    static void Main(string[] args)
    {
        Bai2_1();
        Bai2_2();
        Bai3_1();
        Bai3_2();
        Bai5_1();
        Bai5_2();
        Bai6_2();
    }
    static void Bai2_1()
    {
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 2.1: TRUY VẤN MẢNG SỐ NGUYÊN");
        Console.WriteLine("==================================================");
        Console.WriteLine($"Mảng gốc: {string.Join(", ", mangSo)}\n");


        // Câu a: Liệt kê các phần tử chia hết cho 4 và 3
        // Method Syntax
        var cauA_Method = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);

        // Query Syntax
        var cauA_Query = from x in mangSo
                         where x % 4 == 0 && x % 3 == 0
                         select x;

        Console.WriteLine("   Câu a: Chia hết cho 4 và 3");
        Console.WriteLine($"[Method Syntax]: {string.Join(", ", cauA_Method)}");
        Console.WriteLine($"[Query Syntax]: {string.Join(", ", cauA_Query)}\n");



        // Câu b: Liệt kê các phần tử nhỏ hơn hoặc bằng 3
        // Method Syntax
        var cauB_Method = mangSo.Where(x => x <= 3);

        // Query Syntax
        var cauB_Query = from x in mangSo
                         where x <= 3
                         select x;

        Console.WriteLine("   Câu b: Nhỏ hơn hoặc bằng 3");
        Console.WriteLine($"[Method Syntax]: {string.Join(", ", cauB_Method)}");
        Console.WriteLine($"[Query Syntax] : {string.Join(", ", cauB_Query)}\n");




        // Câu c: Số chẵn chia đôi, số lẻ giữ nguyên
        // Method Syntax
        var cauC_Method = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);

        // Query Syntax
        var cauC_Query = from x in mangSo
                         select (x % 2 == 0 ? x / 2 : x);

        Console.WriteLine("   Câu c: Số chẵn chia đôi, số lẻ giữ nguyên");
        Console.WriteLine($"[Method Syntax]: {string.Join(", ", cauC_Method)}");
        Console.WriteLine($"[Query Syntax] : {string.Join(", ", cauC_Query)}");
    }

    static void Bai2_2()
    {
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 2.2: TRUY VẤN MẢNG CHUỖI");
        Console.WriteLine("==================================================");

        // Câu a: Phần tử có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên
        // Method Syntax
        var cauA_Method = mangChuoi
                            .Where(s => s.Length == 4)
                            .OrderBy(s => s[0]);

        // Query Syntax
        var cauA_Query = from s in mangChuoi
                         where s.Length == 4
                         orderby s[0] ascending
                         select s;

        Console.WriteLine("\n   Câu a: Có 4 ký tự, tăng dần theo ký tự đầu");
        Console.WriteLine($"[Method Syntax]: {string.Join(", ", cauA_Method)}");
        Console.WriteLine($"[Query Syntax] : {string.Join(", ", cauA_Query)}");



        // Câu b: Biến đổi thành dạng: <chữ thường> - <CHỮ HOA>
        // Method Syntax
        var cauB_Method = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");

        // Query Syntax
        var cauB_Query = from s in mangChuoi
                         select $"{s.ToLower()} - {s.ToUpper()}";

        Console.WriteLine("\n   Câu b: Chuyển dạng <thường> - <HOA>");
        Console.WriteLine($"[Method Syntax]:\n{string.Join("\n", cauB_Method)}");
        Console.WriteLine($"[Query Syntax] :\n{string.Join("\n", cauB_Query)}");



        // Câu c: Liệt kê các phần tử có chứa ký tự "u"
        // Method Syntax
        var cauC_Method = mangChuoi.Where(s => s.Contains('u'));

        // Query Syntax
        var cauC_Query = from s in mangChuoi
                         where s.Contains('u')
                         select s;

        Console.WriteLine("\n   Câu c: Phần tử có chứa ký tự 'u'");
        Console.WriteLine($"[Method Syntax]: {string.Join(", ", cauC_Method)}");
        Console.WriteLine($"[Query Syntax] : {string.Join(", ", cauC_Query)}");



        // Câu d: Liệt kê các từ bắt đầu bằng chữ in hoa
        // Method Syntax
        var cauD_Method = mangChuoi.Where(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]));

        // Query Syntax
        var cauD_Query = from s in mangChuoi
                         where !string.IsNullOrEmpty(s) && char.IsUpper(s[0])
                         select s;

        Console.WriteLine("\n   Câu d: Các từ bắt đầu bằng chữ hoa");
        Console.WriteLine($"[Method Syntax]: {string.Join(" ", cauD_Method)}");
        Console.WriteLine($"[Query Syntax] : {string.Join(" ", cauD_Query)}");
    }

    static void Bai3_1()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 3.1: THỐNG KÊ MẢNG SỐ");
        Console.WriteLine("==================================================");
        Console.WriteLine($"Mảng gốc: {string.Join(", ", mangSo)}\n");



        // Câu a: Đếm tổng số phần tử, số chẵn và số lẻ
        int tongSoPhanTu = mangSo.Count();
        int soChan = mangSo.Count(x => x % 2 == 0);
        int soLe = mangSo.Count(x => x % 2 != 0);

        Console.WriteLine("   Câu a: Số lượng phần tử");
        Console.WriteLine($"- Tổng số phần tử : {tongSoPhanTu}");
        Console.WriteLine($"- Số phần tử chẵn : {soChan}");
        Console.WriteLine($"- Số phần tử lẻ   : {soLe}\n");



        // Câu b: Tổng giá trị, Max và Min
        int tongGiaTri = mangSo.Sum();
        int max = mangSo.Max();
        int min = mangSo.Min();

        Console.WriteLine("   Câu b: Tính toán tổng, Max, Min");
        Console.WriteLine($"- Tổng các giá trị : {tongGiaTri}");
        Console.WriteLine($"- Giá trị lớn nhất : {max}");
        Console.WriteLine($"- Giá trị nhỏ nhất : {min}\n");



        // Câu c: Đếm số lượng giá trị khác nhau (Distinct)
        int soGiaTriKhacNhau = mangSo.Distinct().Count();

        Console.WriteLine("   Câu c: Giá trị phân biệt");
        Console.WriteLine($"- Số lượng giá trị khác nhau: {soGiaTriKhacNhau}");
        Console.WriteLine($"- Danh sách các giá trị khác nhau: {string.Join(", ", mangSo.Distinct())}\n");



        // Câu d: Phân nhóm theo số dư khi chia cho 5
        Console.WriteLine("   Câu d: Phân nhóm theo số dư khi chia cho 5");

        // Method Syntax:
        var nhomTheoSoDu_Method = mangSo.GroupBy(x => x % 5);

        // Query Syntax:
        var nhomTheoSoDu_Query = from x in mangSo
                                 group x by x % 5 into g
                                 orderby g.Key ascending // sắp xếp số dư tăng dần cho dễ nhìn
                                 select g;

        // Duyệt qua từng nhóm để in số dư (Key) và các phần tử trong nhóm
        foreach (var group in nhomTheoSoDu_Query)
        {
            Console.WriteLine($"Số dư {group.Key}: {string.Join(", ", group)}");
        }
    }

    static void Bai3_2()
    {
        string[] monAn = {
        "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
        "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
        "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang"
    };
        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 3.2: THỐNG KÊ MẢNG CHUỖI");
        Console.WriteLine("==================================================");


        // Câu a: Tìm các phần tử có chiều dài ngắn nhất và dài nhất
        int minLength = monAn.Min(x => x.Length);
        int maxLength = monAn.Max(x => x.Length);

        // Method Syntax
        var nganNhat_Method = monAn.Where(x => x.Length == minLength);
        var daiNhat_Method = monAn.Where(x => x.Length == maxLength);

        // Query Syntax
        var nganNhat_Query = from x in monAn
                             where x.Length == minLength
                             select x;

        var daiNhat_Query = from x in monAn
                            where x.Length == maxLength
                            select x;

        Console.WriteLine("\n   Câu a: Phần tử ngắn nhất và dài nhất");
        Console.WriteLine($"- Độ dài ngắn nhất ({minLength} ký tự):");
        Console.WriteLine($"  + [Method]: {string.Join(", ", nganNhat_Method)}");
        Console.WriteLine($"  + [Query] : {string.Join(", ", nganNhat_Query)}");

        Console.WriteLine($"- Độ dài dài nhất ({maxLength} ký tự):");
        Console.WriteLine($"  + [Method]: {string.Join(", ", daiNhat_Method)}");
        Console.WriteLine($"  + [Query] : {string.Join(", ", daiNhat_Query)}");




        // Câu b: Phân nhóm theo từ đầu tiên của tên món
        Console.WriteLine("\n   Câu b: Phân nhóm theo từ đầu tiên");

        // Method Syntax
        var nhomMonAn_Method = monAn.GroupBy(x => x.Split(' ')[0]);

        // Query Syntax
        var nhomMonAn_Query = from x in monAn
                              group x by x.Split(' ')[0] into g
                              select g;

        // In cấu trúc nhóm đầy đủ theo theo nhãn
        Console.WriteLine("[Kết quả phân nhóm]:");
        foreach (var group in nhomMonAn_Query)
        {
            Console.WriteLine($"  * Nhóm '{group.Key}' ({group.Count()} món):");
            foreach (var item in group)
            {
                Console.WriteLine($"      - {item}");
            }
        }




        // Câu c: Đếm số phần tử có từ đầu tiên là "Bánh"
        // Cách 1: Dùng Count trực tiếp với điều kiện
        int soLuongBanh = monAn.Count(x => x.Split(' ')[0] == "Bánh");

        // Cách 2: Tận dụng kết quả đã nhóm ở câu b
        // int soLuongBanhTuNhom = nhomMonAn_Query.FirstOrDefault(g => g.Key == "Bánh")?.Count() ?? 0;

        Console.WriteLine("\n   Câu c: Đếm số món có từ đầu tiên là 'Bánh'");
        Console.WriteLine($"- Số lượng món có từ đầu tiên là 'Bánh': {soLuongBanh}");
        Console.WriteLine($"- Danh sách các món đó: {string.Join(", ", monAn.Where(x => x.Split(' ')[0] == "Bánh"))}");
    }


    //============================
    //Câu 4.1
    //============================
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }

        public override string ToString()
        {
            return $"[{MaMon}] {TenMon} | Hệ: {He} | Số tiết: {SoTiet}";
        }
    }

    public static class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "JLCB",  TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
                new MonHoc { MaMon = "LINQ",  TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
                new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "CC++",  TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
                new MonHoc { MaMon = "JQUE",  TenMon = "JQuery", He = "CD", SoTiet = 22 },
                new MonHoc { MaMon = "XML",   TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "CRYS",  TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "BWEB",  TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "XYZ",   TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
            };
        }

        // Danh sách hệ đào tạo (Bài 6.1)
        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
                new He { MaHe = "CD",  TenHe = "Chuyên đề" },
                new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
            };
        }
    }

    static void Bai5_1()
    {
        var dsMon = DuLieu.DS_Mon();
        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 5.1: TRUY VẤN CƠ BẢN TRÊN LIST<MONHOC>");
        Console.WriteLine("==================================================");


        // Câu a: Liệt kê tên các môn học bắt đầu bằng "Lập trình"
        // Method Syntax
        var cauA_Method = dsMon
                            .Where(m => m.TenMon.StartsWith("Lập trình"))
                            .Select(m => m.TenMon);

        // Query Syntax
        var cauA_Query = from m in dsMon
                         where m.TenMon.StartsWith("Lập trình")
                         select m.TenMon;

        Console.WriteLine("\n   Câu a: Tên các môn bắt đầu bằng 'Lập trình'");
        foreach (var ten in cauA_Method)
        {
            Console.WriteLine($"  - {ten}");
        }



        // Câu b: Hệ "CD", sắp xếp số tiết giảm dần rồi mã môn tăng dần
        // Method Syntax
        var cauB_Method = dsMon
                            .Where(m => m.He == "CD")
                            .OrderByDescending(m => m.SoTiet)
                            .ThenBy(m => m.MaMon);

        // Query Syntax
        var cauB_Query = from m in dsMon
                         where m.He == "CD"
                         orderby m.SoTiet descending, m.MaMon ascending
                         select m;

        Console.WriteLine("\n   Câu b: Các môn hệ 'CD' (Số tiết giảm dần, Mã môn tăng dần)");
        foreach (var m in cauB_Method)
        {
            Console.WriteLine($"  {m}");
        }




        // Câu c: Tên chứa từ "web", chỉ lấy Tên môn và Hệ
        // Method Syntax
        var cauC_Method = dsMon
                            .Where(m => m.TenMon.ToLower().Contains("web"))
                            .Select(m => new { m.TenMon, m.He });

        // Query Syntax
        var cauC_Query = from m in dsMon
                         where m.TenMon.ToLower().Contains("web")
                         select new { m.TenMon, m.He };

        Console.WriteLine("\nCâu c: Các môn có tên chứa 'web' (Tên môn và Hệ)");
        foreach (var item in cauC_Method)
        {
            Console.WriteLine($"  - Tên môn: {item.TenMon} | Hệ: {item.He}");
        }


        // Câu d: Hệ "KTV", sắp xếp tăng dần theo Mã môn
        // Method Syntax
        var cauD_Method = dsMon
                            .Where(m => m.He == "KTV")
                            .OrderBy(m => m.MaMon);

        // Query Syntax
        var cauD_Query = from m in dsMon
                         where m.He == "KTV"
                         orderby m.MaMon ascending
                         select m;

        Console.WriteLine("\nCâu d: Các môn hệ 'KTV' sắp xếp tăng dần theo Mã môn");
        foreach (var m in cauD_Method)
        {
            Console.WriteLine($"  {m}");
        }
    }


    static void Bai5_2()
    {
        var dsMon = DuLieu.DS_Mon();

        Console.WriteLine("==================================================");
        Console.WriteLine("=== BÀI 5.2: THỐNG KÊ TRÊN LIST<MONHOC>       ===");
        Console.WriteLine("==================================================");

        // ----------------------------------------------------
        // Câu a: Tổng số môn hiện có
        // ---------------------------------------------------- 
        int tongSoMon = dsMon.Count();
        Console.WriteLine($"\n   Câu a: Tổng số môn hiện có: {tongSoMon}");

        // ----------------------------------------------------
        // Câu b: Đếm số môn có tên bắt đầu bằng "Lập trình"
        // ----------------------------------------------------
        int soMonLapTrinh = dsMon.Count(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"\n   Câu b: Số môn có tên bắt đầu bằng 'Lập trình': {soMonLapTrinh}");

        // ----------------------------------------------------
        // Câu c: Tính tổng số tiết của hệ Kỹ thuật viên (KTV)
        // ----------------------------------------------------
        int tongTietKTV = dsMon.Where(m => m.He == "KTV").Sum(m => (int)m.SoTiet);
        Console.WriteLine($"\n    Câu c: Tổng số tiết của hệ KTV: {tongTietKTV}");

        // ----------------------------------------------------
        // Câu d: Tổng số môn của mỗi hệ: Hệ, Tổng số môn
        // ----------------------------------------------------
        var tkSoMonMoiHe = dsMon
            .GroupBy(m => string.IsNullOrEmpty(m.He) ? "Chưa xác định" : m.He)
            .Select(g => new { He = g.Key, TongSoMon = g.Count() });

        Console.WriteLine("\n   Câu d: Tổng số môn của mỗi hệ");
        foreach (var item in tkSoMonMoiHe)
        {
            Console.WriteLine($"  - Hệ: {item.He,-15} | Tổng số môn: {item.TongSoMon}");
        }

        // ----------------------------------------------------
        // Câu e: Nhóm theo Số tiết; in Số tiết và Tổng số môn, giảm dần theo Số tiết
        // ----------------------------------------------------
        var tkTheoSoTiet = dsMon
            .GroupBy(m => m.SoTiet)
            .OrderByDescending(g => g.Key)
            .Select(g => new { SoTiet = g.Key, TongSoMon = g.Count() });

        Console.WriteLine("\n   Câu e: Thống kê số môn theo Số tiết (Giảm dần)");
        foreach (var item in tkTheoSoTiet)
        {
            Console.WriteLine($"  - Số tiết: {item.SoTiet,3} tiết | Tổng số môn: {item.TongSoMon}");
        }

        // ----------------------------------------------------
        // Câu f: Cho biết thông tin môn học có số tiết cao nhất
        // ----------------------------------------------------
        byte maxSoTiet = dsMon.Max(m => m.SoTiet);
        var monCaoNhat = dsMon.Where(m => m.SoTiet == maxSoTiet);

        Console.WriteLine($"\n   Câu f: Môn học có số tiết cao nhất ({maxSoTiet} tiết)");
        foreach (var m in monCaoNhat)
        {
            Console.WriteLine($"  {m}");
        }

        // ----------------------------------------------------
        // Câu g: Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
        // ----------------------------------------------------
        var tkChiTietHe = dsMon
            .GroupBy(m => string.IsNullOrEmpty(m.He) ? "Chưa xác định" : m.He)
            .Select(g => new
            {
                He = g.Key,
                TongSoMon = g.Count(),
                TongSoTiet = g.Sum(m => (int)m.SoTiet),
                MaxTiet = g.Max(m => m.SoTiet),
                MinTiet = g.Min(m => m.SoTiet)
            });

        Console.WriteLine("\n   Câu g: Thống kê tổng hợp theo từng Hệ");
        foreach (var item in tkChiTietHe)
        {
            Console.WriteLine($"  * Hệ: {item.He}");
            Console.WriteLine($"    + Tổng số môn : {item.TongSoMon}");
            Console.WriteLine($"    + Tổng số tiết: {item.TongSoTiet}");
            Console.WriteLine($"    + Số tiết Max : {item.MaxTiet}");
            Console.WriteLine($"    + Số tiết Min : {item.MinTiet}");
        }


        // ----------------------------------------------------
        // Câu i: Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết
        // ----------------------------------------------------
        var nhomTheoTietTangDan = dsMon
            .GroupBy(m => m.SoTiet)
            .OrderBy(g => g.Key);

        Console.WriteLine("\n   Câu i: Phân nhóm môn học theo Số tiết (Tăng dần)");
        foreach (var group in nhomTheoTietTangDan)
        {
            Console.WriteLine($"  [Nhóm {group.Key} tiết] (gồm {group.Count()} môn):");
            foreach (var m in group)
            {
                Console.WriteLine($"     + [{m.MaMon}] {m.TenMon}");
            }
        }

        // ----------------------------------------------------
        // Câu j: Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn
        // ----------------------------------------------------
        var nhomHocPhanKTV = dsMon
            .Where(m => m.He == "KTV")
            .GroupBy(m => m.MaMon.Contains('_') ? m.MaMon.Split('_')[0] : "Khác")
            .OrderBy(g => g.Key);

        Console.WriteLine("\n   Câu j: Phân nhóm môn hệ KTV theo Học phần (HP2, HP3,...)");
        foreach (var group in nhomHocPhanKTV)
        {
            Console.WriteLine($"  [Học phần: {group.Key}]:");
            // Sắp xếp theo Mã môn trong nội bộ nhóm
            foreach (var m in group.OrderBy(x => x.MaMon))
            {
                Console.WriteLine($"     + [{m.MaMon}] {m.TenMon}");
            }
        }

        // ----------------------------------------------------
        // Câu k: Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn
        // ----------------------------------------------------
        var nhomHeTietLonHon40 = dsMon
            .Where(m => m.SoTiet > 40)
            .GroupBy(m => string.IsNullOrEmpty(m.He) ? "Chưa xác định" : m.He);

        Console.WriteLine("\n   Câu k: Phân nhóm theo Hệ (Chỉ lấy môn có Số tiết > 40)");
        foreach (var group in nhomHeTietLonHon40)
        {
            Console.WriteLine($"  [Hệ: {group.Key}]:");
            // Trong mỗi nhóm sắp xếp tăng dần theo Mã môn
            foreach (var m in group.OrderBy(x => x.MaMon))
            {
                Console.WriteLine($"     + [{m.MaMon}] {m.TenMon} ({m.SoTiet} tiết)");
            }
        }
    }



    //===============================
    //Câu 6.1
    //===========================
    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";

        public override string ToString()
        {
            return $"[{MaHe}] {TenHe}";
        }
    }




    static void Bai6_2()
    {
        var dsMon = DuLieu.DS_Mon();
        var dsHe = DuLieu.DS_He();

        Console.WriteLine("==================================================");
        Console.WriteLine("      BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP");
        Console.WriteLine("==================================================");

        // ----------------------------------------------------
        // Câu a: Dùng join để liệt kê: Tên hệ, Mã môn, Tên môn
        // ----------------------------------------------------
        // Query Syntax
        var cauA_Query = from m in dsMon
                         join h in dsHe on m.He equals h.MaHe
                         select new { h.TenHe, m.MaMon, m.TenMon };

        Console.WriteLine("\n   Câu a: Inner Join (Tên hệ, Mã môn, Tên môn)");
        foreach (var item in cauA_Query)
        {
            Console.WriteLine($"  [{item.TenHe,-18}] {item.MaMon,-6} | {item.TenMon}");
        }

        // ----------------------------------------------------
        // Câu b: Left outer join với GroupJoin + DefaultIfEmpty (Liệt kê cả hệ chưa có môn)
        // ----------------------------------------------------
        var cauB_Query = from h in dsHe
                         join m in dsMon on h.MaHe equals m.He into g
                         from subMon in g.DefaultIfEmpty()
                         select new
                         {
                             TenHe = h.TenHe,
                             MaMon = subMon != null ? subMon.MaMon : "(Chưa có)",
                             TenMon = subMon != null ? subMon.TenMon : "(Chưa có môn nào)"
                         };

        Console.WriteLine("\n   Câu b: Left Outer Join (Kể cả hệ chưa có môn học)");
        foreach (var item in cauB_Query)
        {
            Console.WriteLine($"  [{item.TenHe,-18}] {item.MaMon,-8} | {item.TenMon}");
        }

        // ----------------------------------------------------
        // Câu c: Liệt kê cả hệ chưa có môn và môn học chưa khai báo hệ (Full Outer Join)
        // ----------------------------------------------------
        // 1. Phía Hệ nối sang Môn (Left Join)
        var leftJoin = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into g
                       from subMon in g.DefaultIfEmpty()
                       select new
                       {
                           TenHe = h.TenHe,
                           MaMon = subMon != null ? subMon.MaMon : "(Trống)",
                           TenMon = subMon != null ? subMon.TenMon : "(Hệ chưa có môn)"
                       };

        // 2. Những môn học có mã hệ không nằm trong danh sách hệ
        var rightExclusion = from m in dsMon
                             where !dsHe.Any(h => h.MaHe == m.He)
                             select new
                             {
                                 TenHe = "(Chưa khai báo hệ)",
                                 MaMon = m.MaMon,
                                 TenMon = m.TenMon
                             };

        var cauC = leftJoin.Union(rightExclusion);

        Console.WriteLine("\n--- Câu c: Full Outer Join (Cả hệ chưa có môn và môn chưa có hệ) ---");
        foreach (var item in cauC)
        {
            Console.WriteLine($"  [{item.TenHe,-20}] {item.MaMon,-8} | {item.TenMon}");
        }

        // ----------------------------------------------------
        // Câu d: Chỉ liệt kê những hệ chưa có môn học VÀ những môn học chưa khai báo hệ
        // ----------------------------------------------------
        var heChuaCoMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe))
                              .Select(h => $"  - Hệ chưa có môn: [{h.MaHe}] {h.TenHe}");

        var monChuaKhaiBaoHe = dsMon.Where(m => !dsHe.Any(h => h.MaHe == m.He))
                                    .Select(m => $"  - Môn chưa có hệ: [{m.MaMon}] {m.TenMon}");

        Console.WriteLine("\n--- Câu d: Các hệ chưa có môn và các môn chưa khai báo hệ ---");
        foreach (var item in heChuaCoMon.Concat(monChuaKhaiBaoHe))
        {
            Console.WriteLine(item);
        }

        // ----------------------------------------------------
        // Câu e: Lấy 5 môn học đầu tiên có số tiết giảm dần
        // ----------------------------------------------------
        var cauE = (from m in dsMon
                    join h in dsHe on m.He equals h.MaHe into g
                    from subHe in g.DefaultIfEmpty()
                    orderby m.SoTiet descending
                    select new
                    {
                        TenHe = subHe != null ? subHe.TenHe : "Chưa xác định",
                        m.MaMon,
                        m.TenMon,
                        m.SoTiet
                    }).Take(5);

        Console.WriteLine("\n--- Câu e: Top 5 môn có số tiết cao nhất ---");
        foreach (var item in cauE)
        {
            Console.WriteLine($"  [{item.TenHe,-15}] {item.MaMon,-6} | {item.TenMon,-38} | {item.SoTiet} tiết");
        }

        // ----------------------------------------------------
        // Câu f: Thống kê số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn
        // ----------------------------------------------------
        var cauF = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into g
                   select new
                   {
                       h.MaHe,
                       h.TenHe,
                       TongSoMon = g.Count()
                   };

        Console.WriteLine("\n--- Câu f: Thống kê số môn của mỗi hệ ---");
        foreach (var item in cauF)
        {
            Console.WriteLine($"  [{item.MaHe,-4}] {item.TenHe,-20} : {item.TongSoMon} môn");
        }

        // ----------------------------------------------------
        // Câu g: Đếm số loại Số tiết khác nhau trong danh sách môn học
        // ----------------------------------------------------
        int soLoaiTiet = dsMon.Select(m => m.SoTiet).Distinct().Count();
        var cacLoaiTiet = dsMon.Select(m => m.SoTiet).Distinct().OrderBy(t => t);

        Console.WriteLine("\n--- Câu g: Các mức số tiết khác nhau ---");
        Console.WriteLine($"- Số lượng loại số tiết khác nhau: {soLoaiTiet}");
        Console.WriteLine($"- Cụ thể gồm các mức: {string.Join(", ", cacLoaiTiet)} tiết");

        // ----------------------------------------------------
        // Câu h: Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình"
        // ----------------------------------------------------
        var monDauTien = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));

        Console.WriteLine("\n--- Câu h: Môn học đầu tiên bắt đầu bằng 'Lập trình' ---");
        if (monDauTien != null)
        {
            Console.WriteLine($"  {monDauTien}");
        }
        else
        {
            Console.WriteLine("  Không tìm thấy môn thỏa mãn điều kiện.");
        }

        // ----------------------------------------------------
        // Câu i: Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm
        // ----------------------------------------------------
        var cauI = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into g
                   select new
                   {
                       TenHe = h.TenHe,
                       DanhSachMon = g.Select((m, index) => new { STT = index + 1, m.MaMon, m.TenMon })
                   };

        Console.WriteLine("\n--- Câu i: Liệt kê môn theo hệ và đánh số thứ tự nội bộ ---");
        foreach (var nhom in cauI)
        {
            Console.WriteLine($"\n  * Hệ: {nhom.TenHe}");
            if (!nhom.DanhSachMon.Any())
            {
                Console.WriteLine("      (Chưa có môn học nào)");
                continue;
            }

            foreach (var m in nhom.DanhSachMon)
            {
                Console.WriteLine($"      {m.STT,2}. [{m.MaMon}] {m.TenMon}");
            }
        }
    }
}