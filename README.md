# Project 2: Pencarian Nilai dalam Array

Proyek ini adalah aplikasi konsol sederhana yang dibangun dengan C# dan .NET 8. Tujuan utamanya adalah untuk mendemonstrasikan implementasi algoritma pencarian linear dasar untuk menemukan sebuah nilai (target) di dalam sebuah array integer.

## Daftar Isi

- [Tentang Proyek](#tentang-proyek)
- [Struktur Proyek](#struktur-proyek)
- [Prasyarat](#prasyarat)
- [Cara Menjalankan](#cara-menjalankan)
- [Penjelasan Kode](#penjelasan-kode)
  - [Metode `Main`](#metode-main)
  - [Metode `FindTarget`](#metode-findtarget)
- [Kontribusi](#kontribusi)

## Tentang Proyek

Aplikasi ini dirancang sebagai contoh edukatif bagi pemula yang ingin memahami konsep-konsep dasar pemrograman dalam C#, seperti:

- Deklarasi dan inisialisasi array.
- Penggunaan loop (`for`) untuk iterasi.
- Pernyataan kondisional (`if`).
- Pembuatan dan pemanggilan metode statis.
- Pencetakan output ke konsol.

Program ini secara spesifik mengimplementasikan **pencarian linear**, di mana setiap elemen dalam array diperiksa satu per satu hingga nilai target ditemukan atau hingga seluruh elemen telah diperiksa.

## Struktur Proyek

```
/
├── .gitignore         # Mengabaikan file dan direktori yang tidak perlu dilacak Git
├── Program.cs         # File utama yang berisi semua logika C#
├── PROJECT 2.csproj   # File konfigurasi proyek .NET
└── README.md          # Dokumentasi proyek (file ini)
```

## Prasyarat

Pastikan Anda telah menginstal perangkat lunak berikut di sistem Anda:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) atau versi yang lebih baru.

Anda dapat memeriksa versi .NET yang terinstal dengan menjalankan perintah:

```bash
dotnet --version
```

## Cara Menjalankan

1. **Clone Repositori (Opsional)**
   Jika proyek ini berada di sebuah repositori Git, Anda bisa meng-clone-nya:

   ```bash
   git clone https://github.com/Eko-347m4n/PROJECT2.git
   cd PROJECT2
   ```

2. **Jalankan Aplikasi**
   Buka terminal atau command prompt di direktori root proyek, lalu jalankan perintah berikut:

   ```bash
   dotnet run
   ```

3. **Output yang Diharapkan**
   Setelah dieksekusi, Anda akan melihat output berikut di konsol:

   ```
   Target has been reached in index number 3

   Target has been reached in index number 1

   Target not found in array data
   ```

## Penjelasan Kode

Logika utama program terdapat dalam file `Program.cs`.

### Metode `Main`

Metode `Main` adalah titik masuk (entry point) dari aplikasi. Di sinilah program mulai dieksekusi. Metode ini bertanggung jawab untuk:

1. Menyiapkan tiga skenario pengujian (`Case 1`, `Case 2`, `Case 3`) dengan data array dan nilai target yang berbeda.
2. Memanggil metode `FindTarget` untuk setiap skenario.
3. Mencetak baris kosong di antara setiap kasus untuk keterbacaan output.

```csharp
public static void Main(string[] args)
{
    // Case 1
    int[] numbers1 = { 1, 2, 3, 4, 5 };
    int target1 = 4;
    FindTarget(numbers1, target1);

    Console.WriteLine();

    // Case 2
    int[] numbers2 = { 2, 4, 3 };
    int target2 = 4;
    FindTarget(numbers2, target2);

    Console.WriteLine();

    // Case 3
    int[] numbers3 = { 1, 5, 8, 9 };
    int target3 = 2;
    FindTarget(numbers3, target3);
}
```

### Metode `FindTarget`

Metode ini berisi logika inti untuk melakukan pencarian.

- **Parameter**: Menerima sebuah array integer (`numbers`) dan sebuah nilai integer (`target`).
- **Proses**:
  1. Menggunakan loop `for` untuk mengunjungi setiap elemen array dari indeks `0` hingga akhir.
  2. Di setiap iterasi, ia membandingkan elemen saat ini (`numbers[i]`) dengan `target`.
  3. Jika elemen ditemukan, ia akan mencetak pesan yang berisi indeks di mana target ditemukan, lalu keluar dari loop menggunakan `break` untuk efisiensi.
  4. Jika loop selesai tanpa menemukan target, sebuah pesan akan dicetak untuk menginformasikan bahwa target tidak ada dalam array.

```csharp
public static void FindTarget(int[] numbers, int target)
{
    bool found = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            Console.WriteLine($"Target has been reached in index number {i}");
            found = true;
            break; // Keluar dari loop jika target sudah ditemukan
        }
    }

    if (!found)
    {
        Console.WriteLine("Target not found in array data");
    }
}
```

## Kontribusi

Kontribusi untuk pengembangan proyek ini sangat diterima. Jika Anda ingin berkontribusi, silakan lakukan fork pada repositori ini dan buat _pull request_ dengan perubahan yang Anda usulkan.
