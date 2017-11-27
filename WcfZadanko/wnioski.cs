namespace WcfZadanko
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("morp.wnioski")]
    public partial class wnioski
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wnioski()
        {
            decyzje = new HashSet<decyzje>();
        }

        [Key]
        public int id_wniosek { get; set; }

        public int? id_doradca { get; set; }

        public int? id_glowny_produkt { get; set; }

        public DateTime? data_podpisania_wniosku { get; set; }

        public DateTime? data_rejestracji_wniosku { get; set; }

        [StringLength(128)]
        public string klient_skrot { get; set; }

        public int? id_uzytkownika { get; set; }

        public int? okres_kredytowania { get; set; }

        public int? okres_karencji { get; set; }

        public int? id_waluta { get; set; }

        public int id_rodzaj_raty { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(10)]
        public string numer_wniosku { get; set; }

        public DateTime? faktyczna_data_rejestracji_wniosku { get; set; }

        public double? wnioskowana_kwota_kredytu { get; set; }

        public int? id_produkt { get; set; }

        public int id_oddzial { get; set; }

        public int id_profil_doradcy { get; set; }

        public int id_departamentu { get; set; }

        public bool? czy_wyslano { get; set; }

        public DateTime? data_wyslania { get; set; }

        public int? id_profil_doradcy2 { get; set; }

        public int? id_oddzial_doradcy2 { get; set; }

        public int? id_wniosek_zaangazowania_def { get; set; }

        public int? id_wniosek_pierwotny { get; set; }

        public int? id_klasyfikacja_wniosku { get; set; }

        public bool? czy_z_oddzialu { get; set; }

        public int? id_zrodlo_drop { get; set; }

        public int? id_wniosek_zewn { get; set; }

        public bool? czy_przeslane_do_def { get; set; }

        public int? numer_wniosku_liczbowo { get; set; }

        public int? id_profil_wlasciciel { get; set; }

        public int? id_oddzial_wlasciciel { get; set; }

        public int? id_profil_doradcy_posprzedazowy { get; set; }

        public int? id_oddzial_doradcy_posprzedazowy { get; set; }

        public int? id_profil_doradcy_docelowego { get; set; }

        public int? id_oddzial_doradcy_docelowego { get; set; }

        [StringLength(15)]
        public string klient_posiada_rachunek { get; set; }

        public bool czy_kam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<decyzje> decyzje { get; set; }
    }
}
