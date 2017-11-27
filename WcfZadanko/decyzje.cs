namespace WcfZadanko
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("morp.decyzje")]
    public partial class decyzje
    {
        [Key]
        public int id_decyzja { get; set; }

        public DateTime? data_wprowadzenia_decyzji { get; set; }

        public int? id_produkt { get; set; }

        public int id_wniosek { get; set; }

        public string komentarz_oficjalny_at { get; set; }

        public string komentarz_wewnetrzny_at { get; set; }

        public DateTime? data_analizy_at { get; set; }

        public int? status_analizy_at { get; set; }

        public string komentarz_oficjalny_ap { get; set; }

        public string komentarz_wewnetrzny_ap { get; set; }

        public DateTime? data_analizy_ap { get; set; }

        public int? status_analizy_ap { get; set; }

        public string komentarz_oficjalny_af { get; set; }

        public string komentarz_wewnetrzny_af { get; set; }

        public DateTime? data_analizy_af { get; set; }

        public int? status_analizy_af { get; set; }

        public decimal? marza_cel_mieszkaniowy { get; set; }

        public decimal? marza_cel_niemieszkaniowy { get; set; }

        public decimal? marza_cel_inwestycyjny { get; set; }

        public decimal? marza_cel_dowolny { get; set; }

        public decimal? marza_wazona { get; set; }

        public decimal? marza_w_dniu_udzielenia { get; set; }

        public decimal? marza_docelowa { get; set; }

        public decimal? marza_redukcja { get; set; }

        public decimal? marza_podwyzszenie { get; set; }

        [StringLength(64)]
        public string marza_redukcja_przyczyna { get; set; }

        [StringLength(256)]
        public string marza_podwyzszenie_przyczyna { get; set; }

        public decimal? marza_podwyzszenie_pomost { get; set; }

        public decimal? oprocentowanie { get; set; }

        public decimal? oprocentowanie_w_dniu_udzielenia { get; set; }

        public decimal? indeks_pln { get; set; }

        public DateTime? indeks_z_dnia { get; set; }

        public decimal? rata_do_umowy { get; set; }

        public decimal? rata_do_umowy_odsetkowa { get; set; }

        public decimal? rata_prognoza { get; set; }

        public decimal? rata_prognoza_odsetkowa { get; set; }

        public decimal? rata_do_zdolnosci { get; set; }

        public DateTime? waznosc_decyzji_do { get; set; }

        public decimal? kwota_kredytu_netto { get; set; }

        public decimal? prowizja_bankowa_procent { get; set; }

        public decimal? kwota_kredytu_brutto { get; set; }

        public decimal? max_kwota_kredytu { get; set; }

        public bool? czy_prowizja_gotowka { get; set; }

        public decimal? prowizja_bankowa_kwota { get; set; }

        public DateTime? data_decyzji { get; set; }

        public int? id_rodzaj_stawki { get; set; }

        public int? id_poziom_akceptacji { get; set; }

        public int? id_typ_karencji { get; set; }

        public int? okres_kredytowania { get; set; }

        public int? okres_karencji { get; set; }

        public int? id_waluta { get; set; }

        public int? id_rodzaj_raty { get; set; }

        public int? id_sposob_uruchomienia { get; set; }

        public decimal? ltv_netto { get; set; }

        public decimal? ltv_brutto { get; set; }

        public decimal? ltv_nieruchomosci { get; set; }

        public int? id_pelnomocnik_do_korespondencji { get; set; }

        public int? termin_splaty_raty { get; set; }

        public int? id_rodzaj_oprocentowania { get; set; }

        public int? okres_linii_kredytowej { get; set; }

        public decimal? prowizja_linii_kredytowej { get; set; }

        public bool? czy_prowizja_staloprocentowa { get; set; }

        public int? ilosc_gospodarstw_na_utrzymaniu { get; set; }

        public int? ilosc_osob_na_utrzymaniu { get; set; }

        [StringLength(10)]
        public string symbol_mr { get; set; }

        [StringLength(8192)]
        public string komentarz_poziom_akceptacji { get; set; }

        [StringLength(1024)]
        public string kwota_kredytu_powodzmniejszenia { get; set; }

        [StringLength(20)]
        public string bik_score { get; set; }

        public decimal? wartosc_mr { get; set; }

        public string komentarz_oficjalny_bramka { get; set; }

        public string komentarz_wewnetrzny_bramka { get; set; }

        public string komentarz_wewnetrzny_afw { get; set; }

        public string komentarz_oficjalny_afw { get; set; }

        public int? id_klasyfikacja_umowy { get; set; }

        public int? id_grupa_ryzyka { get; set; }

        public decimal? wskaznik_dti { get; set; }

        public string komentarz_oficjalny { get; set; }

        public string komentarz_wewnetrzny { get; set; }

        public int? id_oferta_specjalna { get; set; }

        public string wskaznik_mr_komentarz { get; set; }

        public string komentarz_do_umowy { get; set; }

        public bool czy_weryfikacja_wstepna { get; set; }

        public string czynniki_ryzyka { get; set; }

        public decimal? marza_cel_zakup_akcji { get; set; }

        public int? id_zawod_zaufania { get; set; }

        public int? id_limit_kredytowy { get; set; }

        public decimal? limit_kredytowy_wartosc { get; set; }

        public decimal? limit_kredytowy_krotnosc { get; set; }

        public decimal? prowizja_za_przedluzenie { get; set; }

        public decimal? krotnosc_obrotow { get; set; }

        public bool? czy_abonament_tc { get; set; }

        public int? czy_abo_tc_kto_zmienil { get; set; }

        public DateTime? czy_abo_tc_data_zmiany { get; set; }

        public decimal? wklad_wlasny_wniesiony { get; set; }

        public decimal? wklad_wlasny_do_wniesienia { get; set; }

        public int? zop_id_oferta_specjalna { get; set; }

        public int? id_info_uruchomienia_dla_zzp { get; set; }

        public int? id_info_uruchomienia_dla_operacji { get; set; }

        public int? id_info_uruchomienia_dla_zop { get; set; }

        public int? id_info_uruchomienia_dla_klienta { get; set; }

        public decimal? rentownosc_kwota { get; set; }

        public decimal? rentownosc_procent { get; set; }

        public decimal? obnizka_prowizji_posrednika { get; set; }

        public decimal? rata_do_zdolnosci_odsetkowa { get; set; }

        public bool? czy_staly_monitoring { get; set; }

        public int? czy_staly_monitoring_kto_zmienil { get; set; }

        public DateTime? czy_staly_monitoring_data_zmiany { get; set; }

        public int? id_prowizja_przedluzenie { get; set; }

        public int? id_prowizja_gotowosc_srodkow { get; set; }

        public bool czy_produkt_spo { get; set; }

        public int? zop_id_oferta_specjalna_zop { get; set; }

        public bool? czy_blokada_marzy_kontomierz { get; set; }

        public int? zgoda_na_odstepstwo_id_uzytkownik { get; set; }

        public DateTime? zgoda_na_odstepstwo_data { get; set; }

        public int? okres_do_zdolnosci { get; set; }

        public decimal? balon_wartosc { get; set; }

        [StringLength(64)]
        public string nr_umowy_crm { get; set; }

        public int? id_sl_karta_glowna_wlasciciel { get; set; }

        public int? id_sl_karta_dodatkowa_wlasciciel { get; set; }

        public decimal oprocentowanie_karty { get; set; }

        public string karta_kredytowa_komentarz { get; set; }

        public int? karta_kredytowa_data_splaty { get; set; }

        public int? karta_kredytowa_okres_kredytowania { get; set; }

        public decimal? marza_cel_gospodarczy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_podpisania_umowy { get; set; }

        public string czynniki_minimalizujace_ryzyko { get; set; }

        public decimal? obnizka_stawki_wibor { get; set; }

        public decimal? max_ltv_na_produkcie { get; set; }

        public decimal? max_kwota_na_produkcie { get; set; }

        public decimal? kwota_wykorzystana { get; set; }

        public decimal? kwota_ponad_karte_produktu { get; set; }

        public decimal? ltv_ponad_karte_produktu { get; set; }

        public int? id_sl_poziom_akceptacji_aneks { get; set; }

        public int? id_termin_splaty_raty { get; set; }

        public decimal? indeks_lombard { get; set; }

        [StringLength(32)]
        public string scoring_aplikacyjny { get; set; }

        public bool? czy_knt_prognoza { get; set; }

        public int? komentarz_poziom_akceptacji_id_edytor { get; set; }

        public DateTime? komentarz_poziom_akceptacji_data_zmiany { get; set; }

        public decimal? ltv_laczne { get; set; }

        public bool? czy_knt_pdf { get; set; }

        public bool? czy_knt_wyciag_z_rachunkow_klienta { get; set; }

        public bool? czy_od_uruchomienia_aneksu { get; set; }

        public bool? is_shadow { get; set; }

        public decimal? oprocentowanie_z_kosztem_ubezpieczenia_z_decyzji { get; set; }

        public decimal oprocentowanie_w_dniu_udzielenia_przed_redukcja { get; set; }

        public decimal szacunkowa_rata_calkowita_przed_redukcja_oprocentowania { get; set; }

        public decimal rata_calkowita_przed_redukcja_oprocentowania { get; set; }

        public decimal? ltv_nieruchomosci_nowe { get; set; }

        public decimal? ltv_ruchomosci { get; set; }

        public decimal? ltv_mieszane { get; set; }

        public int? id_sl_marza_niski_wklad { get; set; }

        public int? id_sl_ltv_niski_wklad { get; set; }

        public decimal? stawka_prowizji_za_prolongate { get; set; }

        public decimal? wartosc_prowizji_za_prolongate { get; set; }

        public decimal? procentbalonfair { get; set; }

        public bool? czyprocentbalon { get; set; }

        public decimal? balon_fair { get; set; }

        [StringLength(2048)]
        public string weryfikacja_socjotech { get; set; }

        public bool czy_knt_pit_kpir { get; set; }

        public decimal? stawka_prowizji_za_rozlozenie_splaty_kredytu { get; set; }

        public decimal? wartosc_prowizji_za_rozlozenie_splaty_kredytu { get; set; }

        public decimal? wartosc_prowizji_za_przedluzenie { get; set; }

        public int? id_zrodlo { get; set; }

        public int? id_knt_zrodlo_oferty { get; set; }

        public bool metoda_dochodowa_biznesplan_checked { get; set; }

        public decimal metoda_dochodowa_biznesplan_kwota { get; set; }

        public decimal? marza_cel_konsolidacyjny { get; set; }

        public int? id_sl_bik_kod_oceny { get; set; }

        public virtual wnioski wnioski { get; set; }
    }
}
