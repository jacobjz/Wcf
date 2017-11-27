namespace WcfZadanko
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Rex9 : DbContext
    {
        public Rex9()
            : base("name=Rex9")
        {
        }

        public virtual DbSet<decyzje> decyzje { get; set; }
        public virtual DbSet<wnioski> wnioski { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_mieszkaniowy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_niemieszkaniowy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_inwestycyjny)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_dowolny)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_wazona)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_w_dniu_udzielenia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_docelowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_redukcja)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_podwyzszenie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_podwyzszenie_pomost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.oprocentowanie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.oprocentowanie_w_dniu_udzielenia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.indeks_pln)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_do_umowy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_do_umowy_odsetkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_prognoza)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_prognoza_odsetkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_do_zdolnosci)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.kwota_kredytu_netto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.prowizja_bankowa_procent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.kwota_kredytu_brutto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.max_kwota_kredytu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.prowizja_bankowa_kwota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_netto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_brutto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_nieruchomosci)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.prowizja_linii_kredytowej)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wartosc_mr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wskaznik_dti)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_zakup_akcji)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.limit_kredytowy_wartosc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.limit_kredytowy_krotnosc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.prowizja_za_przedluzenie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.krotnosc_obrotow)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wklad_wlasny_wniesiony)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wklad_wlasny_do_wniesienia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rentownosc_kwota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rentownosc_procent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.obnizka_prowizji_posrednika)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_do_zdolnosci_odsetkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.balon_wartosc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.oprocentowanie_karty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_gospodarczy)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.obnizka_stawki_wibor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.max_ltv_na_produkcie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.max_kwota_na_produkcie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.kwota_wykorzystana)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.kwota_ponad_karte_produktu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_ponad_karte_produktu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.indeks_lombard)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_laczne)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.oprocentowanie_z_kosztem_ubezpieczenia_z_decyzji)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.oprocentowanie_w_dniu_udzielenia_przed_redukcja)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.szacunkowa_rata_calkowita_przed_redukcja_oprocentowania)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.rata_calkowita_przed_redukcja_oprocentowania)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_nieruchomosci_nowe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_ruchomosci)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.ltv_mieszane)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.stawka_prowizji_za_prolongate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wartosc_prowizji_za_prolongate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.procentbalonfair)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.balon_fair)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.stawka_prowizji_za_rozlozenie_splaty_kredytu)
                .HasPrecision(4, 2);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wartosc_prowizji_za_rozlozenie_splaty_kredytu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.wartosc_prowizji_za_przedluzenie)
                .HasPrecision(10, 2);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.metoda_dochodowa_biznesplan_kwota)
                .HasPrecision(10, 2);

            modelBuilder.Entity<decyzje>()
                .Property(e => e.marza_cel_konsolidacyjny)
                .HasPrecision(19, 4);

            modelBuilder.Entity<wnioski>()
                .HasMany(e => e.decyzje)
                .WithRequired(e => e.wnioski)
                .WillCascadeOnDelete(false);
        }
    }
}
