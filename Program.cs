using System;

namespace ComposicionesLOL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region rasgosNombre
            string Acero = "acero", Alquimista = "alquimista", Asesino = "asesino", Berseker = "berseker", Bosque = "bosque", Cazador = "cazador";
            string Cristal = "cristal", Depredador = "depredador", Desierto = "desierto", Druida = "druida", Electrico = "electrico", Espadachin = "espadachin";
            string Gelido = "gelido", Infernal = "infernal", Invocador = "invocador", Luz = "luz", Mago = "mago", Montaña = "montana", Mistico = "mistico";
            string Nube = "nube", Oceano = "oceano", Sombrio = "sombrio", Tanque = "tanque", Veneno = "veneno", Vinculo = "vinculo", Lunar = "lunar", Vacio = "";
            #endregion
            #region rasgosNumero
            int acero = 0, alquimista = 0, asesino = 0, berseker = 0, bosque = 0, cazador = 0;
            int cristal = 0, depredador = 0, desierto = 0, druida = 0, electrico = 0, espadachin = 0;
            int gelido = 0, infernal = 0, invocador = 0, luz = 0, mago = 0, montaña = 0, mistico = 0;
            int nube = 0, oceano = 0, sombrio = 0, tanque = 0, veneno = 0, vinculo = 0, lunar = 0;
            #endregion
            int oro = 0, plata = 0, bronce = 0, sumador = 0, spat = 0;
            string espatula = "";
            Heroes[] Tabla = new Heroes[58];

            #region Heroes
            Heroes renekton = new Heroes();
            renekton.Nombre = "renekton";
            renekton.Rasgo1 = Desierto;
            renekton.Rasgo2 = Berseker;
            renekton.Rasgo3 = Vacio;
            Heroes vayne = new Heroes();
            vayne.Nombre = "vayne";
            vayne.Rasgo1 = Luz;
            vayne.Rasgo2 = Cazador;
            vayne.Rasgo3 = Vacio;
            Heroes maokai = new Heroes();
            maokai.Nombre = "maokai";
            maokai.Rasgo1 = Bosque;
            maokai.Rasgo2 = Druida;
            maokai.Rasgo3 = Vacio;
            Heroes taliyah = new Heroes();
            taliyah.Nombre = "taliyah";
            taliyah.Rasgo1 = Mago;
            taliyah.Rasgo2 = Montaña;
            taliyah.Rasgo3 = Vacio;
            Heroes warwick = new Heroes();
            warwick.Nombre = "warwick";
            warwick.Rasgo1 = Gelido;
            warwick.Rasgo2 = Depredador;
            warwick.Rasgo3 = Vacio;
            Heroes nasus = new Heroes();
            nasus.Nombre = "nasus";
            nasus.Rasgo1 = Luz;
            nasus.Rasgo2 = Tanque;
            nasus.Rasgo3 = Vacio;
            Heroes ivern = new Heroes();
            ivern.Nombre = "ivern";
            ivern.Rasgo1 = Bosque;
            ivern.Rasgo2 = Druida;
            ivern.Rasgo3 = Vacio;
            Heroes kogMaw = new Heroes();
            kogMaw.Nombre = "kogMaw";
            kogMaw.Rasgo1 = Veneno;
            kogMaw.Rasgo2 = Depredador;
            kogMaw.Rasgo3 = Vacio;
            Heroes diana = new Heroes();
            diana.Nombre = "diana";
            diana.Rasgo1 = Infernal;
            diana.Rasgo2 = Asesino;
            diana.Rasgo3 = Vacio;
            Heroes vladimir = new Heroes();
            vladimir.Nombre = "vladimir";
            vladimir.Rasgo1 = Oceano;
            vladimir.Rasgo2 = Mago;
            vladimir.Rasgo3 = Vacio;
            Heroes ornn = new Heroes();
            ornn.Nombre = "ornn";
            ornn.Rasgo1 = Tanque;
            ornn.Rasgo2 = Electrico;
            ornn.Rasgo3 = Vacio;
            Heroes zyra = new Heroes();
            zyra.Nombre = "zyra";
            zyra.Rasgo1 = Infernal;
            zyra.Rasgo2 = Invocador;
            zyra.Rasgo3 = Vacio;
            Heroes leblanc = new Heroes();
            leblanc.Nombre = "leblanc";
            leblanc.Rasgo1 = Bosque;
            leblanc.Rasgo2 = Asesino;
            leblanc.Rasgo3 = Mago;
            Heroes varus = new Heroes();
            varus.Nombre = "varus";
            varus.Rasgo1 = Infernal;
            varus.Rasgo2 = Cazador;
            varus.Rasgo3 = Vacio;
            Heroes thresh = new Heroes();
            thresh.Nombre = "thresh";
            thresh.Rasgo1 = Tanque;
            thresh.Rasgo2 = Oceano;
            thresh.Rasgo3 = Vacio;
            Heroes yasuo = new Heroes();
            yasuo.Nombre = "yasuo";
            yasuo.Rasgo1 = Nube;
            yasuo.Rasgo2 = Espadachin;
            yasuo.Rasgo3 = Vacio;
            Heroes malzahar = new Heroes();
            malzahar.Nombre = "malzahar";
            malzahar.Rasgo1 = Sombrio;
            malzahar.Rasgo2 = Invocador;
            malzahar.Rasgo3 = Vacio;
            Heroes volibear = new Heroes();
            volibear.Nombre = "volibear";
            volibear.Rasgo1 = Gelido;
            volibear.Rasgo2 = Electrico;
            volibear.Rasgo3 = Berseker;
            Heroes syndra = new Heroes();
            syndra.Nombre = "syndra";
            syndra.Rasgo1 = Oceano;
            syndra.Rasgo2 = Mago;
            syndra.Rasgo3 = Vacio;
            Heroes neeko = new Heroes();
            neeko.Nombre = "neeko";
            neeko.Rasgo1 = Bosque;
            neeko.Rasgo2 = Druida;
            neeko.Rasgo3 = Vacio;
            Heroes jax = new Heroes();
            jax.Nombre = "jax";
            jax.Rasgo1 = Luz;
            jax.Rasgo2 = Berseker;
            jax.Rasgo3 = Vacio;
            Heroes reksai = new Heroes();
            reksai.Nombre = "reksai";
            reksai.Rasgo1 = Acero;
            reksai.Rasgo2 = Depredador;
            reksai.Rasgo3 = Vacio;
            Heroes skarner = new Heroes();
            skarner.Nombre = "skarner";
            skarner.Rasgo1 = Cristal;
            skarner.Rasgo2 = Depredador;
            skarner.Rasgo3 = Vacio;
            Heroes braum = new Heroes();
            braum.Nombre = "braum";
            braum.Rasgo1 = Gelido;
            braum.Rasgo2 = Tanque;
            braum.Rasgo3 = Vacio;
            Heroes qiyananube = new Heroes();
            qiyananube.Nombre = "qiyananube";
            qiyananube.Rasgo1 = Nube;
            qiyananube.Rasgo2 = Asesino;
            qiyananube.Rasgo3 = Vacio;
            Heroes qiyanaoceano = new Heroes();
            qiyanaoceano.Nombre = "qiyanaoceano";
            qiyanaoceano.Rasgo1 = Asesino;
            qiyanaoceano.Rasgo2 = Oceano;
            qiyanaoceano.Rasgo3 = Vacio;
            Heroes sivir = new Heroes();
            sivir.Nombre = "sivir";
            sivir.Rasgo1 = Espadachin;
            sivir.Rasgo2 = Desierto;
            sivir.Rasgo3 = Vacio;
            Heroes ezreal = new Heroes();
            ezreal.Nombre = "ezreal";
            ezreal.Rasgo1 = Gelido;
            ezreal.Rasgo2 = Cazador;
            ezreal.Rasgo3 = Vacio;
            Heroes drMundo = new Heroes();
            drMundo.Nombre = "drMundo";
            drMundo.Rasgo1 = Veneno;
            drMundo.Rasgo2 = Berseker;
            drMundo.Rasgo3 = Vacio;
            Heroes nocturne = new Heroes();
            nocturne.Nombre = "nocturne";
            nocturne.Rasgo1 = Asesino;
            nocturne.Rasgo2 = Acero;
            nocturne.Rasgo3 = Vacio;
            Heroes qiyanaInfernal = new Heroes();
            qiyanaInfernal.Nombre = "qiyanaInfernal";
            qiyanaInfernal.Rasgo1 = Infernal;
            qiyanaInfernal.Rasgo2 = Asesino;
            qiyanaInfernal.Rasgo3 = Vacio;
            Heroes aatrox = new Heroes();
            aatrox.Nombre = "aatrox";
            aatrox.Rasgo1 = Luz;
            aatrox.Rasgo2 = Espadachin;
            aatrox.Rasgo3 = Vacio;
            Heroes soraka = new Heroes();
            soraka.Nombre = "soraka";
            soraka.Rasgo1 = Luz;
            soraka.Rasgo2 = Mistico;
            soraka.Rasgo3 = Vacio;
            Heroes kindred = new Heroes();
            kindred.Nombre = "kindred";
            kindred.Rasgo1 = Sombrio;
            kindred.Rasgo2 = Infernal;
            kindred.Rasgo3 = Cazador;
            Heroes sion = new Heroes();
            sion.Nombre = "sion";
            sion.Rasgo1 = Berseker;
            sion.Rasgo2 = Sombrio;
            sion.Rasgo3 = Vacio;
            Heroes veigar = new Heroes();
            veigar.Nombre = "veigar";
            veigar.Rasgo1 = Sombrio;
            veigar.Rasgo2 = Mago;
            veigar.Rasgo3 = Vacio;
            Heroes qiyanaMontaña = new Heroes();
            qiyanaMontaña.Nombre = "qiyanaMontaña";
            qiyanaMontaña.Rasgo1 = Montaña;
            qiyanaMontaña.Rasgo2 = Asesino;
            qiyanaMontaña.Rasgo3 = Vacio;
            Heroes azir = new Heroes();
            azir.Nombre = "azir";
            azir.Rasgo1 = Invocador;
            azir.Rasgo2 = Desierto;
            azir.Rasgo3 = Vacio;
            Heroes nautilus = new Heroes();
            nautilus.Nombre = "nautilus";
            nautilus.Rasgo1 = Oceano;
            nautilus.Rasgo2 = Tanque;
            nautilus.Rasgo3 = Vacio;
            Heroes malphite = new Heroes();
            malphite.Nombre = "malphite";
            malphite.Rasgo1 = Tanque;
            malphite.Rasgo2 = Montaña;
            malphite.Rasgo3 = Vacio;
            Heroes khazix = new Heroes();
            khazix.Nombre = "khazix";
            khazix.Rasgo1 = Desierto;
            khazix.Rasgo2 = Asesino;
            khazix.Rasgo3 = Vacio;
            Heroes janna = new Heroes();
            janna.Nombre = "janna";
            janna.Rasgo1 = Nube;
            janna.Rasgo2 = Mistico;
            janna.Rasgo3 = Vacio;
            Heroes twitch = new Heroes();
            twitch.Nombre = "twitch";
            twitch.Rasgo1 = Veneno;
            twitch.Rasgo2 = Cazador;
            twitch.Rasgo3 = Vacio;
            Heroes brand = new Heroes();
            brand.Nombre = "brand";
            brand.Rasgo1 = Mago;
            brand.Rasgo2 = Infernal;
            brand.Rasgo3 = Vacio;
            Heroes annie = new Heroes();
            annie.Nombre = "annie";
            annie.Rasgo1 = Infernal;
            annie.Rasgo2 = Invocador;
            annie.Rasgo3 = Vacio;
            Heroes olaf = new Heroes();
            olaf.Nombre = "olaf";
            olaf.Rasgo1 = Berseker;
            olaf.Rasgo2 = Gelido;
            olaf.Rasgo3 = Vacio;
            Heroes ashe = new Heroes();
            ashe.Nombre = "ashe";
            ashe.Rasgo1 = Cazador;
            ashe.Rasgo2 = Cristal;
            ashe.Rasgo3 = Vacio;
            Heroes yorick = new Heroes();
            yorick.Nombre = "yorick";
            yorick.Rasgo1 = Luz;
            yorick.Rasgo2 = Invocador;
            yorick.Rasgo3 = Vacio;
            Heroes singed = new Heroes();
            singed.Nombre = "singed";
            singed.Rasgo1 = Alquimista;
            singed.Rasgo2 = Veneno;
            singed.Rasgo3 = Vacio;
            Heroes zed = new Heroes();
            zed.Nombre = "zed";
            zed.Rasgo1 = Electrico;
            zed.Rasgo2 = Invocador;
            zed.Rasgo3 = Asesino;
            Heroes taric = new Heroes();
            taric.Nombre = "taric";
            taric.Rasgo1 = Tanque;
            taric.Rasgo2 = Cristal;
            taric.Rasgo3 = Vacio;
            Heroes nami = new Heroes();
            nami.Nombre = "nami";
            nami.Rasgo1 = Oceano;
            nami.Rasgo2 = Mistico;
            nami.Rasgo3 = Vacio;
            Heroes maestroYi = new Heroes();
            maestroYi.Nombre = "maestroYi";
            maestroYi.Rasgo1 = Sombrio;
            maestroYi.Rasgo2 = Mistico;
            maestroYi.Rasgo3 = Espadachin;
            Heroes senna = new Heroes();
            senna.Nombre = "senna";
            senna.Rasgo1 = Sombrio;
            senna.Rasgo2 = Vinculo;
            senna.Rasgo3 = Vacio;
            Heroes lucian = new Heroes();
            lucian.Nombre = "lucian";
            lucian.Rasgo1 = Luz;
            lucian.Rasgo2 = Vinculo;
            lucian.Rasgo3 = Vacio;
            Heroes amumu = new Heroes();
            amumu.Nombre = "amumu";
            amumu.Rasgo1 = Infernal;
            amumu.Rasgo2 = Tanque;
            amumu.Rasgo3 = Vacio;
            Heroes leona = new Heroes();
            leona.Nombre = "leona";
            leona.Rasgo1 = Lunar;
            leona.Rasgo2 = Tanque;
            leona.Rasgo3 = Vacio;
            Heroes karma = new Heroes();
            karma.Nombre = "karma";
            karma.Rasgo1 = Lunar;
            karma.Rasgo2 = Mistico;
            karma.Rasgo3 = Vacio;
            #endregion

            #region asignacionTabla
            Tabla[0] = diana;
            Tabla[1] = karma;
            Tabla[2] = maokai;
            Tabla[3] = taliyah;
            Tabla[4] = warwick;
            Tabla[5] = nasus;
            Tabla[6] = ivern;
            Tabla[7] = kogMaw;
            Tabla[8] = leona;
            Tabla[9] = vladimir;
            Tabla[10] = ornn;
            Tabla[11] = zyra;
            Tabla[12] = leblanc;
            Tabla[13] = varus;
            Tabla[14] = thresh;
            Tabla[15] = yasuo;
            Tabla[16] = malzahar;
            Tabla[17] = volibear;
            Tabla[18] = syndra;
            Tabla[19] = neeko;
            Tabla[20] = jax;
            Tabla[21] = reksai;
            Tabla[22] = skarner;
            Tabla[23] = braum;
            Tabla[24] = qiyananube;
            Tabla[25] = qiyanaoceano;
            Tabla[26] = sivir;
            Tabla[27] = ezreal;
            Tabla[28] = drMundo;
            Tabla[29] = nocturne;
            Tabla[30] = qiyanaInfernal;
            Tabla[31] = aatrox;
            Tabla[32] = soraka;
            Tabla[33] = kindred;
            Tabla[34] = sion;
            Tabla[35] = veigar;
            Tabla[36] = qiyanaMontaña;
            Tabla[37] = azir;
            Tabla[38] = nautilus;
            Tabla[39] = malphite;
            Tabla[40] = khazix;
            Tabla[41] = janna;
            Tabla[42] = twitch;
            Tabla[43] = brand;
            Tabla[44] = annie;
            Tabla[45] = olaf;
            Tabla[46] = ashe;
            Tabla[47] = yorick;
            Tabla[48] = singed;
            Tabla[49] = zed;
            Tabla[50] = taric;
            Tabla[51] = nami;
            Tabla[52] = maestroYi;
            Tabla[53] = senna;
            Tabla[54] = lucian;
            Tabla[55] = amumu;
            Tabla[56] = renekton;
            Tabla[57] = vayne;
            #endregion

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(Tabla[i].Nombre);
                for (int j = i + 1; j <= 51; j++) 
                {
                    for (int k = j + 1; k <= 52; k++)
                    {
                        for (int l = k + 1; l <= 53; l++)
                        {
                            for (int m = l + 1; m <= 54; m++)
                            {
                                for (int n = m + 1; n <= 55; n++)
                                {
                                    for (int o = n + 1; o <= 56; o++)
                                    {
                                        for (int p = o + 1; p <= 57; p++)
                                        {
                                            contarRasgos(Tabla[i].Rasgo1, Tabla[i].Rasgo2, Tabla[i].Rasgo3);
                                            contarRasgos(Tabla[j].Rasgo1, Tabla[j].Rasgo2, Tabla[j].Rasgo3);
                                            contarRasgos(Tabla[k].Rasgo1, Tabla[k].Rasgo2, Tabla[k].Rasgo3);
                                            contarRasgos(Tabla[l].Rasgo1, Tabla[l].Rasgo2, Tabla[l].Rasgo3);
                                            contarRasgos(Tabla[m].Rasgo1, Tabla[m].Rasgo2, Tabla[m].Rasgo3);
                                            contarRasgos(Tabla[n].Rasgo1, Tabla[n].Rasgo2, Tabla[n].Rasgo3);
                                            contarRasgos(Tabla[o].Rasgo1, Tabla[o].Rasgo2, Tabla[o].Rasgo3);
                                            contarRasgos(Tabla[p].Rasgo1, Tabla[p].Rasgo2, Tabla[p].Rasgo3);
                                            int comparer = compararRangos();
                                            //if ((sumador > 18 && (oro > 0 | plata > 0)) | sumador > 18)
                                            if (comparer == 0) 
                                            {
                                                Console.Write(Tabla[i].Nombre + ", " + Tabla[j].Nombre + ", " + Tabla[k].Nombre + ", " +
                                                Tabla[l].Nombre + ", " + Tabla[m].Nombre + ", " + Tabla[n].Nombre + ", " + Tabla[o].Nombre + ", " +
                                                Tabla[p].Nombre + ". Oro: " + oro + ", Plata: " + plata + ", Bronce: " + bronce + " "+ comparer +" "+ sumador + " " + espatula);
                                                Console.WriteLine();
                                            }
                                            //if (comparer == 1 && sumador > 12) 
                                            //{
                                            //    Console.Write(Tabla[i].Nombre + ", " + Tabla[j].Nombre + ", " + Tabla[k].Nombre + ", " +
                                            //    Tabla[l].Nombre + ", " + Tabla[m].Nombre + ", " + Tabla[n].Nombre + ", " + Tabla[o].Nombre + ", " +
                                            //    Tabla[p].Nombre + ". Oro: " + oro + ", Plata: " + plata + ", Bronce: " + bronce + ". 1");
                                            //    Console.WriteLine();
                                            //}
                                            BorrarDatos();

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            void contarRasgos(string cadena1, string cadena2, string cadena3)
            {
                if (cadena1 == Acero | cadena2 == Acero | cadena3 == Acero) 
                    acero++;
                if (cadena1 == Alquimista | cadena2 == Alquimista | cadena3 == Alquimista)
                    alquimista++;
                if (cadena1 == Asesino | cadena2 == Asesino | cadena3 == Asesino)
                    asesino++;
                if (cadena1 == Berseker | cadena2 == Berseker | cadena3 == Berseker)
                    berseker++;
                if (cadena1 == Bosque | cadena2 == Bosque | cadena3 == Bosque)
                    bosque++;
                if (cadena1 == Cazador | cadena2 == Cazador | cadena3 == Cazador)
                    cazador++;
                if (cadena1 == Cristal | cadena2 == Cristal | cadena3 == Cristal)
                    cristal++;
                if (cadena1 == Depredador | cadena2 == Depredador | cadena3 == Depredador)
                    depredador++;
                if (cadena1 == Desierto | cadena2 == Desierto | cadena3 == Desierto)
                    desierto++;
                if (cadena1 == Druida | cadena2 == Druida | cadena3 == Druida)
                    druida++;
                if (cadena1 == Electrico | cadena2 == Electrico | cadena3 == Electrico)
                    electrico++;
                if (cadena1 == Espadachin | cadena2 == Espadachin | cadena3 == Espadachin)
                    espadachin++;
                if (cadena1 == Gelido | cadena2 == Gelido | cadena3 == Gelido)
                    gelido++;
                if (cadena1 == Infernal | cadena2 == Infernal | cadena3 == Infernal)
                    infernal++;
                if (cadena1 == Invocador | cadena2 == Invocador | cadena3 == Invocador)
                    invocador++;
                if (cadena1 == Luz | cadena2 == Luz | cadena3 == Luz)
                    luz++;
                if (cadena1 == Mago | cadena2 == Mago | cadena3 == Mago)
                    mago++;
                if (cadena1 == Montaña | cadena2 == Montaña | cadena3 == Montaña)
                    montaña++;
                if (cadena1 == Mistico | cadena2 == Mistico | cadena3 == Mistico)
                    mistico++;
                if (cadena1 == Nube | cadena2 == Nube | cadena3 == Nube)
                    nube++;
                if (cadena1 == Oceano | cadena2 == Oceano | cadena3 == Oceano)
                    oceano++;
                if (cadena1 == Sombrio | cadena2 == Sombrio | cadena3 == Sombrio)
                    sombrio++;
                if (cadena1 == Tanque | cadena2 == Tanque | cadena3 == Tanque)
                    tanque++;
                if (cadena1 == Veneno | cadena2 == Veneno | cadena3 == Veneno)
                    veneno++;
                if (cadena1 == Vinculo | cadena2 == Vinculo | cadena3 == Vinculo)
                    vinculo++;
                if (cadena1 == Lunar | cadena2 == Lunar | cadena3 == Lunar)
                    lunar++;
            }
            int compararRangos()
            {
                int conter = 26;
                if (acero == 0 | acero == 2 | acero == 3 | acero == 4)
                {
                    conter--;
                    compararCalidad(234, acero);
                }
                if (alquimista == 0 | alquimista == 1)
                {
                    conter--;
                    compararCalidad(1, alquimista);
                }
                if ((asesino == 0 | asesino == 3 | asesino == 6) | (spat == 0 && asesino == 2 | asesino == 5))
                {
                    if (asesino == 2 | asesino == 5 && espatula == "") 
                    {
                        spat = 1;
                        asesino++;
                        espatula = "asesino";
                    }
                    conter--;
                    compararCalidad(36, asesino);
                }
                if ((berseker == 0 | berseker == 3 | berseker == 6) | (spat == 0 && berseker == 2 | berseker == 5))
                {
                    if (berseker == 2 | berseker == 5 && espatula == "")
                    {
                        spat = 1;
                        berseker++;
                        espatula = "berseker";
                    }
                    conter--;
                    compararCalidad(36, berseker);
                }
                if (bosque == 0 | bosque == 3)
                {
                    conter--;
                    compararCalidad(3, bosque);
                }
                if (cazador == 0 | cazador == 2 | cazador == 4 | cazador == 6)
                {
                    conter--;
                    compararCalidad(246, cazador);
                }
                if (cristal == 0 | cristal == 2 | cristal == 4)
                {
                    conter--;
                    compararCalidad(24, cristal);
                }
                if (depredador == 0 | depredador == 3)
                {
                    conter--;
                    compararCalidad(3, depredador);
                }
                if (desierto == 0 | desierto == 2 | desierto == 4)
                {
                    conter--;
                    compararCalidad(24, desierto);
                }
                if (druida == 0 | druida == 2)
                {
                    conter--;
                    compararCalidad(2, druida);
                }
                if (electrico == 0 | electrico == 2 | electrico == 3 | electrico == 4)
                {
                    conter--;
                    compararCalidad(234, electrico);
                }
                if ((espadachin == 0 | espadachin == 2 | espadachin == 4 | espadachin == 6) | (spat == 0 && espadachin == 1 | espadachin == 3 | espadachin == 5))
                {
                    if (espadachin == 1 | espadachin == 3 | espadachin == 5 && espatula == "")
                    {
                        spat = 1;
                        espadachin++;
                        espatula = "espadachin";
                    }
                    conter--;
                    compararCalidad(246, espadachin);
                }
                if ((gelido == 0 | gelido == 2 | gelido == 4 | gelido == 6) | (spat == 0 && gelido == 1 | gelido == 3 | gelido == 5))
                {
                    if (gelido == 1 | gelido == 3 | gelido == 5 && espatula == "")
                    {
                        spat = 1;
                        gelido++;
                        espatula = "gelido";
                    }
                    conter--;
                    compararCalidad(246, gelido);
                }
                if ((infernal == 0 | infernal == 3 | infernal == 6 | infernal == 9) | (spat == 0 && infernal == 2 | infernal == 5 | infernal == 8))
                {
                    if (infernal == 2 | infernal == 5 | infernal == 8 && espatula == "")
                    {
                        spat = 1;
                        infernal++;
                        espatula = "infernal";
                    }
                    conter--;
                    compararCalidad(369, infernal);
                }
                if (invocador == 0 | invocador == 3 | invocador == 6)
                {
                    conter--;
                    compararCalidad(36, invocador);
                }
                if (lunar == 0 | lunar == 2) 
                {
                    conter--;
                    compararCalidad(2, lunar);
                }
                if ((luz == 0 | luz == 3 | luz == 6 | luz == 9) | (spat == 0 && luz == 2 | luz == 5 | luz == 8))
                {
                    if (luz == 2 | luz == 5 | luz == 8 && espatula == "")
                    {
                        spat = 1;
                        luz++;
                        espatula = "luz";
                    }
                    conter--;
                    compararCalidad(369, luz);
                }
                if ((mago == 0 | mago == 3 | mago == 6 ) | (spat == 0 && mago == 2 | mago == 5))
                {
                    if (mago == 2 | mago == 5 && espatula == "")
                    {
                        spat = 1;
                        mago++;
                        espatula = "mago";
                    }
                    conter--;
                    compararCalidad(36, mago);
                }
                if (montaña == 0 | montaña == 2)
                {
                    conter--;
                    compararCalidad(2, montaña);
                }
                if (mistico == 0 | mistico == 2 | mistico == 4)
                {
                    conter--;
                    compararCalidad(24, mistico);
                }
                if (nube == 0 | nube == 2 | nube == 3 | nube == 4)
                {
                    conter--;
                    compararCalidad(234, nube);
                }
                if (oceano == 0 | oceano == 2 | oceano == 4 | oceano == 6)
                {
                    conter--;
                    compararCalidad(246, oceano);
                }
                if (sombrio == 0 | sombrio == 3 | sombrio == 6)
                {
                    conter--;
                    compararCalidad(36, sombrio);
                }
                if ((tanque == 0 | tanque == 2 | tanque == 4 | tanque == 6) | (spat == 0 && tanque == 1 | tanque == 3 | tanque == 5))
                {
                    if (tanque == 1 | tanque == 3 | tanque == 5 && espatula == "")
                    {
                        spat = 1;
                        tanque++;
                        espatula = "tanque";
                    }
                    conter--;
                    compararCalidad(246, tanque);
                }
                if (veneno == 0 | veneno == 3)
                {
                    conter--;
                    compararCalidad(3, veneno);
                }
                if (vinculo == 0 | vinculo == 2)
                {
                    conter--;
                    compararCalidad(2, vinculo);
                }
                //sumador = Convert.ToInt32(oro * 3 + plata * 2 + bronce);
                return conter;
            }
            void BorrarDatos()
            {
                acero=0;
                alquimista=0;
                asesino=0;
                berseker=0;
                bosque=0;
                cazador=0;
                cristal=0;
                depredador=0;
                desierto=0;
                druida=0;
                electrico=0;
                espadachin=0;
                gelido=0;
                infernal=0;
                invocador=0;
                lunar = 0;
                luz=0;
                mago=0;
                montaña=0;
                mistico=0;
                nube=0;
                oceano=0;
                sombrio=0;
                tanque=0;
                veneno=0;
                vinculo = 0;
                oro = 0;
                plata = 0;
                bronce = 0;
                sumador = 0;
                spat = 0;
                espatula = "";
            }
            void compararCalidad(int rangos, int numero)
            {
                sumador += numero;
                //234 1 36 3 246 24 2 369
                if (rangos==234)
                {
                    if (numero >= 4)
                        oro++;
                    else if (numero >= 3)
                        plata++;
                    else if (numero >= 2)
                        bronce++;
                }
                if ((rangos == 1 | rangos == 2 | rangos == 3) && numero > 0)  
                {
                        oro++;
                }
                if (rangos == 36)
                {
                    if (numero >= 6)
                        oro++;
                    else if (numero >= 3)
                        bronce++;
                }
                if (rangos == 246)
                {
                    if (numero >= 6)
                        oro++;
                    else if (numero >= 4)
                        plata++;
                    else if (numero >= 2)
                        bronce++;
                }
                if (rangos == 24)
                {
                    if (numero >= 4)
                        oro++;
                    else if (numero >= 2)
                        bronce++;
                }
                if (rangos == 369)
                {
                    if (numero >= 9)
                        oro++;
                    else if (numero >= 6)
                        plata++;
                    else if (numero >= 3)
                        bronce++;
                }

            }
        }
    }
}
