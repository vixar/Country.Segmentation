using System;
using System.Collections.Generic;
using System.Text;

namespace Country.Segmentation
{
    public class Municipio
    {
        public string Name { get; set; }
        public string Provincia { get; set; }

        public Municipio(string name, string provincia)
        {
            Name = name;
            Provincia = provincia;
        }
    }
    public static class Municipios
    {

        public static Municipio Altamira = new Municipio("Altamira", "Puerto Plata");
        public static Municipio Arenoso = new Municipio("Arenoso", "Duarte");
        public static Municipio Azua = new Municipio("Azua", " Azua");
        public static Municipio BajosDeHaina = new Municipio("Bajos de Haina", " San Cristóbal");
        public static Municipio Bani = new Municipio("Baní", " Peravia");
        public static Municipio Bánica = new Municipio("Bánica", " Elías Piña");
        public static Municipio Barahona = new Municipio("Barahona", " Barahona");
        public static Municipio Bayaguana = new Municipio("Bayaguana", " Monte Plata");
        public static Municipio Bisono = new Municipio("Bisonó", " Santiago");
        public static Municipio BocaChica = new Municipio("Boca Chica", " Santo Domingo");
        public static Municipio Bohechio = new Municipio("Bohechío", " San Juan");
        public static Municipio Bonao = new Municipio("Bonao", " Monseñor Nouel");
        public static Municipio Cabral = new Municipio("Cabral", " Barahona");
        public static Municipio Cabrera = new Municipio("Cabrera", " María Trinidad Sánchez");
        public static Municipio CambitaGarabitos = new Municipio("Cambita Garabitos", " San Cristóbal");
        public static Municipio Castanuelas = new Municipio("Castañuelas", " Monte Cristi");
        public static Municipio Castillo = new Municipio("Castillo", " Duarte");
        public static Municipio CayetanoGermosen = new Municipio("Cayetano Germosén", " Espaillat");
        public static Municipio Cevicos = new Municipio("Cevicos", " Sánchez Ramírez");
        public static Municipio Comendador = new Municipio("Comendador", " Elías Piña");
        public static Municipio Constanza = new Municipio("Constanza", " La Vega");
        public static Municipio Consuelo = new Municipio("Consuelo", " San Pedro de Macorís");
        public static Municipio Cotui = new Municipio("Cotuí", " Sánchez Ramírez");
        public static Municipio Cristobal = new Municipio("Cristóbal", " Independencia");
        public static Municipio Dajabon = new Municipio("Dajabón", " Dajabón");
        public static Municipio Duverge = new Municipio("Duvergé", " Independencia");
        public static Municipio ElCercado = new Municipio("El Cercado", " San Juan");
        public static Municipio ElFactor = new Municipio("El Factor", " María Trinidad Sánchez");
        public static Municipio ElLlano = new Municipio("El Llano", " Elías Piña");
        public static Municipio ElPenon = new Municipio("El Peñón", " Barahona");
        public static Municipio ElPino = new Municipio("El Pino", " Dajabón");
        public static Municipio ElSeibo = new Municipio("El Seibo", " El Seibo");
        public static Municipio ElValle = new Municipio("El Valle", " Hato Mayor");
        public static Municipio Enriquillo = new Municipio("Enriquillo", " Barahona");
        public static Municipio Esperanza = new Municipio("Esperanza", " Valverde");
        public static Municipio Estebania = new Municipio("Estebanía", " Azua");
        public static Municipio EugenioMariaDeHostos = new Municipio("Eugenio María de Hostos", " Duarte");
        public static Municipio Fantino = new Municipio("Fantino", " Sánchez Ramírez");
        public static Municipio Fundacion = new Municipio("Fundación", " Barahona");
        public static Municipio Galvan = new Municipio("Galván", " Bahoruco");
        public static Municipio GasparHernandez = new Municipio("Gaspar Hernández", " Espaillat");
        public static Municipio Guananico = new Municipio("Guananico", " Puerto Plata");
        public static Municipio Guayabal = new Municipio("Guayabal", " Azua");
        public static Municipio Guayacanes = new Municipio("Guayacanes", " San Pedro de Macorís");
        public static Municipio Guaymate = new Municipio("Guaymate", " La Romana");
        public static Municipio Guayubin = new Municipio("Guayubín", " Monte Cristi");
        public static Municipio HatoMayor = new Municipio("Hato Mayor", " Hato Mayor");
        public static Municipio Higuey = new Municipio("Higüey", " La Altagracia");
        public static Municipio HondoValle = new Municipio("Hondo Valle", " Elías Piña");
        public static Municipio Imbert = new Municipio("Imbert", " Puerto Plata");
        public static Municipio JamaoAlNorte = new Municipio("Jamao Al Norte", " Espaillat");
        public static Municipio Janico = new Municipio("Jánico", " Santiago");
        public static Municipio Jaquimeyes = new Municipio("Jaquimeyes", " Barahona");
        public static Municipio Jarabacoa = new Municipio("Jarabacoa", " La Vega");
        public static Municipio JimaAbajo = new Municipio("Jima Abajo", " La Vega");
        public static Municipio Jimani = new Municipio("Jimaní", " Independencia");
        public static Municipio JuanDeHerrera = new Municipio("Juan de Herrera", " San Juan");
        public static Municipio JuanSantiago = new Municipio("Juan Santiago", " Elías Piña");
        public static Municipio LaCienaga = new Municipio("La Ciénaga", " Barahona");
        public static Municipio LaDescubierta = new Municipio("La Descubierta", " Independencia");
        public static Municipio LagunaSalada = new Municipio("Laguna Salada", " Valverde");
        public static Municipio LaMata = new Municipio("La Mata", " Sánchez Ramírez");
        public static Municipio LaRomana = new Municipio("La Romana", " La Romana");
        public static Municipio LasCharcas = new Municipio("Las Charcas", " Azua");
        public static Municipio LasGuaranas = new Municipio("Las Guáranas", " Duarte");
        public static Municipio LasMatasDeFarfan = new Municipio("Las Matas de Farfán", " San Juan");
        public static Municipio LasMatasDeSantaCruz = new Municipio("Las Matas de Santa Cruz", " Monte Cristi");
        public static Municipio LasSalinas = new Municipio("Las Salinas", " Barahona");
        public static Municipio LasTerrenas = new Municipio("Las Terrenas", " Samaná");
        public static Municipio LasYayasDeViajama = new Municipio("Las Yayas de Viajama", " Azua");
        public static Municipio LaVega = new Municipio("La Vega", " La Vega");
        public static Municipio LiceyAlMedio = new Municipio("Licey al Medio", " Santiago");
        public static Municipio LomaDeCabrera = new Municipio("Loma de Cabrera", " Dajabón");
        public static Municipio LosAlcarrizos = new Municipio("Los Alcarrizos", " Santo Domingo");
        public static Municipio LosCacaos = new Municipio("Los Cacaos", " San Cristóbal");
        public static Municipio LosHidalgos = new Municipio("Los Hidalgos", " Puerto Plata");
        public static Municipio LosLlanos = new Municipio("Los Llanos", " San Pedro de Macorís");
        public static Municipio LosRios = new Municipio("Los Ríos", " Bahoruco");
        public static Municipio Luperon = new Municipio("Luperón", " Puerto Plata");
        public static Municipio Maimon = new Municipio("Maimón", " Monseñor Nouel");
        public static Municipio Mao = new Municipio("Mao", " Valverde");
        public static Municipio Matanzas = new Municipio("Matanzas", " Peravia");
        public static Municipio Mella = new Municipio("Mella", " Independencia");
        public static Municipio Miches = new Municipio("Miches", " El Seibo");
        public static Municipio Moca = new Municipio("Moca", " Espaillat");
        public static Municipio Moncion = new Municipio("Monción", " Santiago Rodríguez");
        public static Municipio MonteCristi = new Municipio("Monte Cristi", " Monte Cristi");
        public static Municipio MontePlata = new Municipio("Monte Plata", " Monte Plata");
        public static Municipio Nagua = new Municipio("Nagua", " María Trinidad Sánchez");
        public static Municipio Neiba = new Municipio("Neiba", " Bahoruco");
        public static Municipio Nizao = new Municipio("Nizao", " Peravia");
        public static Municipio Oviedo = new Municipio("Oviedo", " Pedernales");
        public static Municipio PadreLasCasas = new Municipio("Padre Las Casas", " Azua");
        public static Municipio Paraiso = new Municipio("Paraíso", " Barahona");
        public static Municipio Partido = new Municipio("Partido", " Dajabón");
        public static Municipio Pedernales = new Municipio("Pedernales", " Pedernales");
        public static Municipio PedroBrand = new Municipio("Pedro Brand", " Santo Domingo");
        public static Municipio PedroSantana = new Municipio("Pedro Santana", " Elías Piña");
        public static Municipio PepilloSalcedo = new Municipio("Pepillo Salcedo", " Monte Cristi");
        public static Municipio Peralta = new Municipio("Peralta", " Azua");
        public static Municipio Peralvillo = new Municipio("Peralvillo", " Monte Plata");
        public static Municipio PiedraBlanca = new Municipio("Piedra Blanca", " Monseñor Nouel");
        public static Municipio Pimentel = new Municipio("Pimentel", " Duarte");
        public static Municipio Polo = new Municipio("Polo", " Barahona");
        public static Municipio PostrerRio = new Municipio("Postrer Río", " Independencia");
        public static Municipio PuebloViejo = new Municipio("Pueblo Viejo", " Azua");
        public static Municipio PuertoPlata = new Municipio("Puerto Plata", " Puerto Plata");
        public static Municipio Punal = new Municipio("Puñal", " Santiago");
        public static Municipio Quisqueya = new Municipio("Quisqueya", " San Pedro de Macorís");
        public static Municipio RamonSantana = new Municipio("Ramón Santana", " San Pedro de Macorís");
        public static Municipio RanchoArriba = new Municipio("Rancho Arriba", " San José de Ocoa");
        public static Municipio Restauracion = new Municipio("Restauración", " Dajabón");
        public static Municipio RioSanJuan = new Municipio("Río San Juan", " María Trinidad Sánchez");
        public static Municipio SabanaDeLaMar = new Municipio("Sabana de la Mar", " Hato Mayor");
        public static Municipio SabanaGrandeDeBoya = new Municipio("Sabana Grande de Boyá", " Monte Plata");
        public static Municipio SabanaGrandeDePalenque = new Municipio("Sabana Grande de Palenque", " San Cristóbal");
        public static Municipio SabanaIglesia = new Municipio("Sabana Iglesia", " Santiago");
        public static Municipio SabanaLarga = new Municipio("Sabana Larga", " San José de Ocoa");
        public static Municipio SabanaYegua = new Municipio("Sabana Yegua", " Azua");
        public static Municipio Salcedo = new Municipio("Salcedo", " Hermanas Mirabal");
        public static Municipio Samana = new Municipio("Samaná", " Samaná");
        public static Municipio SanAntonioDeGuerra = new Municipio("San Antonio de Guerra", " Santo Domingo");
        public static Municipio Sanchez = new Municipio("Sánchez", " Samaná");
        public static Municipio SanCristobal = new Municipio("San Cristóbal", " San Cristóbal");
        public static Municipio SanFranciscoDeMacoris = new Municipio("San Francisco de Macorís", " Duarte");
        public static Municipio SanGregorioDeNigua = new Municipio("San Gregorio de Nigua", " San Cristóbal");
        public static Municipio SanIgnacioDeSabaneta = new Municipio("San Ignacio de Sabaneta", " Santiago Rodríguez");
        public static Municipio SanJoseDeLasMatas = new Municipio("San José de Las Matas", " Santiago");
        public static Municipio SanJoseDeOcoa = new Municipio("San José de Ocoa", " San José de Ocoa");
        public static Municipio SanJuan = new Municipio("San Juan", " San Juan");
        public static Municipio SanPedroDeMacoris = new Municipio("San Pedro de Macorís", " San Pedro de Macorís");
        public static Municipio SanRafaelDelYuma = new Municipio("San Rafael del Yuma", " La Altagracia");
        public static Municipio SantiagoDeLosCaballeros = new Municipio("Santiago de los Caballeros", " Santiago");
        public static Municipio SantoDomingoEste = new Municipio("Santo Domingo Este", " Santo Domingo");
        public static Municipio SantoDomingoNorte = new Municipio("Santo Domingo Norte", " Santo Domingo");
        public static Municipio SantoDomingoOeste = new Municipio("Santo Domingo Oeste", " Santo Domingo");
        public static Municipio Sosua = new Municipio("Sosúa", " Puerto Plata");
        public static Municipio TabaraArriba = new Municipio("Tábara Arriba", " Azua");
        public static Municipio Tamayo = new Municipio("Tamayo", " Bahoruco");
        public static Municipio Tamboril = new Municipio("Tamboril", " Santiago");
        public static Municipio Tenares = new Municipio("Tenares", " Hermanas Mirabal");
        public static Municipio Vallejuelo = new Municipio("Vallejuelo", " San Juan");
        public static Municipio VicenteNoble= new Municipio("Vicente Noble"," Barahona");
        public static Municipio VillaAltagracia = new Municipio("Villa Altagracia", " San Cristóbal");
        public static Municipio VillaGonzalez = new Municipio("Villa González", " Santiago");
        public static Municipio VillaHermosa = new Municipio("Villa Hermosa", " La Romana");
        public static Municipio VillaIsabela = new Municipio("Villa Isabela", " Puerto Plata");
        public static Municipio VillaJaragua = new Municipio("Villa Jaragua", " Bahoruco");
        public static Municipio VillaLosAlmacigos = new Municipio("Villa Los Almácigos", " Santiago Rodríguez");
        public static Municipio VillaMontellano = new Municipio("Villa Montellano", " Puerto Plata");
        public static Municipio VillaRiva = new Municipio("Villa Riva", " Duarte");
        public static Municipio VillaTapia = new Municipio("Villa Tapia", " Hermanas Mirabal");
        public static Municipio VillaVasquez = new Municipio("Villa Vásquez", " Monte Cristi");
        public static Municipio Yaguate = new Municipio("Yaguate", " San Cristóbal");
        public static Municipio Yamasa = new Municipio("Yamasá", " Monte Plata");

    }
}
