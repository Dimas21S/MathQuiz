# DeQuiz - Aplikasi Kuis Matematika

## Deskripsi
DeQuiz adalah aplikasi kuis matematika berbasis Windows Forms menggunakan C#. Aplikasi ini memberikan soal matematika sederhana dengan operasi penjumlahan, pengurangan, perkalian, dan pembagian. Pengguna akan mendapatkan poin setiap kali menjawab dengan benar, dan permainan akan berhenti setelah waktu habis.

🎮 Tampilan Aplikasi
Berikut adalah antarmuka dari aplikasi DeQuiz:
![Screenshot 2025-04-07 233541](https://github.com/user-attachments/assets/a0e0c606-6073-4c45-b69a-041307972379)
![Screenshot 2025-04-07 233847](https://github.com/user-attachments/assets/903616cd-26ec-4c3e-8688-ae804e4e90b6)

## Fitur
- ⏱️ Timer otomatis selama 5 menit.
- 🔄 Soal matematika acak: penjumlahan (+), pengurangan (-), perkalian (x), dan pembagian (/).
- ✅ Penilaian otomatis: poin bertambah jika jawaban benar.
- 🔢 Tampilan nomor soal dan total skor secara real-time.
- ⏹️ Permainan berhenti otomatis saat waktu habis.
- ↩️ Bisa menjawab cukup dengan tekan tombol "Enter" pada keyboard.

## Teknologi yang Digunakan
- Bahasa: C#
- GUI   : Windows Forms
- IDE   : Visual Studio

## Cara Menjalankan Aplikasi
1. **Jalankan aplikasi** dengan membuka proyek di Visual Studio dan menjalankannya.
2. **Klik tombol "Start"** untuk memulai kuis.
3. **Klik tombol stop** untuk menghentikan permainan sementara.
4. **Jawab soal yang muncul** dengan mengetikkan jawaban di `textBoxHasil` dan tekan "Enter".
5. **Poin akan bertambah** jika jawaban benar.
6. **Kuis berakhir** setelah 5 menit

## Struktur Kode
- `MathQuiz.cs`: File utama yang menangani logika permainan.
- `Quiz.cs` – Class yang menangani soal, jawaban, dan poin.
- `Time.cs` – Class waktu yang menangani menit dan detik.
- `GenerateQuestion()`: Fungsi untuk membuat soal matematika baru.
- `buttonEnter_Click()`: Memproses jawaban pengguna.
- `timer1_Tick()`: Menghitung waktu permainan.
- `buttonStart_Click()`: Memulai kuis.
- `buttonStop_Click()`: Menghentikan kuis.

## Instalasi dan Konfigurasi
- Instal Visual Studio 2022 (atau versi lebih baru).
- Clone atau download proyek ini ke komputer kamu.
- Buka file .sln di Visual Studio.
- Jalankan aplikasi dengan klik tombol Start (F5).

## Catatan Tambahan
- Aplikasi ini menggunakan `Random` untuk mengacak angka dan operasi.
- Timer dikontrol dengan `timer1.Enabled` untuk mengatur batas waktu permainan.
- Masih terdapat beberapa kesalahan di kode programnya.
- Soal pembagian tidak menyertakan angka desimal.
- Proyek ini masih dalam tahap pengembangan: beberapa fitur dan UI akan terus ditingkatkan.
- Tidak semua skenario error ditangani secara sempurna (yet!).

## Kontributor
- Developer: [Dimas Satyo Wijayanto]
