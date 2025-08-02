using System;
using System.Data;
using System.Data.SqlClient;

namespace GMAO
{
	// Token: 0x02000082 RID: 130
	internal class lancement_ot_preventive
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x000FDD60 File Offset: 0x000FBF60
		public static void creation_ot_compteur(int id_compteur)
		{
			bd bd = new bd();
			string cmdText = "select id_gamme,valeur_lancement, type_valeur, reinitialisation, initial, type_initial, atelier, equipement,sous_equipement, organe, prev_compteur.id from prev_compteur where id_compteur = @i and arr = @a and id not in(select id_prev_compteur from ot_reinit_compteur)";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_compteur;
			sqlCommand.Parameters.Add("@a", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string a = dataTable.Rows[i].ItemArray[2].ToString();
					int num = Convert.ToInt32(dataTable.Rows[i].ItemArray[0]);
					double num2 = Convert.ToDouble(dataTable.Rows[i].ItemArray[1]);
					string a2 = dataTable.Rows[i].ItemArray[3].ToString();
					double num3 = Convert.ToDouble(dataTable.Rows[i].ItemArray[4]);
					int num4 = Convert.ToInt32(dataTable.Rows[i].ItemArray[6]);
					int num5 = Convert.ToInt32(dataTable.Rows[i].ItemArray[7]);
					int num6 = Convert.ToInt32(dataTable.Rows[i].ItemArray[8]);
					int num7 = Convert.ToInt32(dataTable.Rows[i].ItemArray[9]);
					string a3 = Convert.ToString(dataTable.Rows[i].ItemArray[5]);
					int num8 = Convert.ToInt32(dataTable.Rows[i].ItemArray[10]);
					string cmdText2 = "select valeur from equipement_compteur where id = @i";
					SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
					sqlCommand2.Parameters.Add("@i", SqlDbType.Int).Value = id_compteur;
					SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
					DataTable dataTable2 = new DataTable();
					sqlDataAdapter2.Fill(dataTable2);
					bool flag2 = dataTable2.Rows.Count != 0;
					if (flag2)
					{
						double num9 = Convert.ToDouble(dataTable2.Rows[0].ItemArray[0]);
						int num10 = 0;
						bool flag3 = a == "Sup";
						if (flag3)
						{
							bool flag4 = num9 >= num2;
							if (flag4)
							{
								num10 = 1;
							}
						}
						bool flag5 = a == "Inf";
						if (flag5)
						{
							bool flag6 = num9 <= num2;
							if (flag6)
							{
								num10 = 1;
							}
						}
						bool flag7 = num10 == 1;
						if (flag7)
						{
							lancement_ot_preventive.creation_ressource_ot(num, num4, num5, num6, num7, id_compteur, num9, 0, 0.0);
							string cmdText3 = "select max(id) from ordre_travail where id_intervention = @i1 and atelier = @i2 and equipement = @i3 and sous_equipement = @i4 and organe = @i5 and type = @i6";
							SqlCommand sqlCommand3 = new SqlCommand(cmdText3, bd.cnn);
							sqlCommand3.Parameters.Add("@i1", SqlDbType.Int).Value = num;
							sqlCommand3.Parameters.Add("@i2", SqlDbType.Int).Value = num4;
							sqlCommand3.Parameters.Add("@i3", SqlDbType.Int).Value = num5;
							sqlCommand3.Parameters.Add("@i4", SqlDbType.Int).Value = num6;
							sqlCommand3.Parameters.Add("@i5", SqlDbType.Int).Value = num7;
							sqlCommand3.Parameters.Add("@i6", SqlDbType.VarChar).Value = "Préventive Syst Compteur";
							SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(sqlCommand3);
							DataTable dataTable3 = new DataTable();
							sqlDataAdapter3.Fill(dataTable3);
							string value = Convert.ToString(dataTable3.Rows[0].ItemArray[0]);
							bool flag8 = a2 == "Oui";
							if (flag8)
							{
								bool flag9 = a3 == "Au Lancement de l'OT";
								if (flag9)
								{
									string cmdText4 = "update equipement_compteur set valeur = @v where id = @i";
									SqlCommand sqlCommand4 = new SqlCommand(cmdText4, bd.cnn);
									sqlCommand4.Parameters.Add("@i", SqlDbType.Int).Value = id_compteur;
									sqlCommand4.Parameters.Add("@v", SqlDbType.Real).Value = num3;
									bd.ouverture_bd(bd.cnn);
									sqlCommand4.ExecuteNonQuery();
									bd.cnn.Close();
								}
								else
								{
									string cmdText5 = "insert into ot_reinit_compteur(id_prev_compteur, id_ot) values (@i, @v)";
									SqlCommand sqlCommand5 = new SqlCommand(cmdText5, bd.cnn);
									sqlCommand5.Parameters.Add("@i", SqlDbType.Int).Value = num8;
									sqlCommand5.Parameters.Add("@v", SqlDbType.Int).Value = value;
									bd.ouverture_bd(bd.cnn);
									sqlCommand5.ExecuteNonQuery();
									bd.cnn.Close();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000FE26C File Offset: 0x000FC46C
		private static void creation_ressource_ot(int id_gamme, int atelier, int equipement, int sous_equipement, int organe, int id_compteur, double vlr_compteur, int id_mesure, double vlr_mesure)
		{
			bd bd = new bd();
			string cmdText = "select urgence, statut, type, id_classe, id_classe, id_superviseur, duree, var_duree, operation, gamme_operatoire.designation from gamme_operatoire where id = @i";
			string cmdText2 = "select id_fonction, nbre_requis, min_planif, type_cout from gamme_ressources_fonction where id_gamme = @i";
			string cmdText3 = "select id_type, quantite from gamme_ressources_outillage where id_gamme = @i";
			string cmdText4 = "select id_article, quantite from gamme_ressources_pdr where id_gamme = @i";
			string cmdText5 = "select id_centre_charge from gamme_centre_charge where id_gamme = @i";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
			SqlCommand sqlCommand3 = new SqlCommand(cmdText3, bd.cnn);
			SqlCommand sqlCommand4 = new SqlCommand(cmdText4, bd.cnn);
			SqlCommand sqlCommand5 = new SqlCommand(cmdText5, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_gamme;
			sqlCommand.Parameters.Add("@a", SqlDbType.Int).Value = 0;
			sqlCommand2.Parameters.Add("@i", SqlDbType.Int).Value = id_gamme;
			sqlCommand3.Parameters.Add("@i", SqlDbType.Int).Value = id_gamme;
			sqlCommand4.Parameters.Add("@i", SqlDbType.Int).Value = id_gamme;
			sqlCommand5.Parameters.Add("@i", SqlDbType.Int).Value = id_gamme;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(sqlCommand3);
			SqlDataAdapter sqlDataAdapter4 = new SqlDataAdapter(sqlCommand4);
			SqlDataAdapter sqlDataAdapter5 = new SqlDataAdapter(sqlCommand5);
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			DataTable dataTable4 = new DataTable();
			DataTable dataTable5 = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			sqlDataAdapter2.Fill(dataTable2);
			sqlDataAdapter3.Fill(dataTable3);
			sqlDataAdapter4.Fill(dataTable4);
			sqlDataAdapter5.Fill(dataTable5);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				string cmdText6 = "insert into ordre_travail (n_ot, id_di, date_debut, heure_debut, date_fin, heure_fin, urgence, id_intervention, statut, type, id_classe, id_superviseur, commentaire, createur, deleted, atelier, equipement, sous_equipement, organe, id_defaillance, debut_prevu, fin_prevu) values (@i1, @i2, @i3, @i4, @i5, @i6, @i7, @i8, @i9, @i10, @i11, @i13, @i14, @i15, @i16, @i17, @i18, @i19, @i20, @i21, @i22, @i23)SELECT CAST(scope_identity() AS int)";
				SqlCommand sqlCommand6 = new SqlCommand(cmdText6, bd.cnn);
				string cmdText7 = "select id from ordre_travail where year(date_debut) = @y and month(date_debut) = @m and type = @t";
				SqlCommand sqlCommand7 = new SqlCommand(cmdText7, bd.cnn);
				sqlCommand7.Parameters.Add("@y", SqlDbType.Int).Value = DateTime.Today.Year;
				sqlCommand7.Parameters.Add("@m", SqlDbType.Int).Value = DateTime.Today.Month;
				sqlCommand7.Parameters.Add("@t", SqlDbType.VarChar).Value = dataTable.Rows[0].ItemArray[2].ToString();
				SqlDataAdapter sqlDataAdapter6 = new SqlDataAdapter(sqlCommand7);
				DataTable dataTable6 = new DataTable();
				sqlDataAdapter6.Fill(dataTable6);
				string text = "";
				string description = "";
				string text2 = dataTable.Rows[0].ItemArray[9].ToString();
				bool flag2 = dataTable.Rows[0].ItemArray[2].ToString() == "Corrective Curative";
				if (flag2)
				{
					text = "CCR";
				}
				bool flag3 = dataTable.Rows[0].ItemArray[2].ToString() == "Corrective Palliative";
				if (flag3)
				{
					text = "CPL";
				}
				bool flag4 = dataTable.Rows[0].ItemArray[2].ToString() == "Travaux Neufs";
				if (flag4)
				{
					text = "TNF";
				}
				bool flag5 = dataTable.Rows[0].ItemArray[2].ToString() == "Préventive Systématique";
				if (flag5)
				{
					text = "PST";
				}
				bool flag6 = dataTable.Rows[0].ItemArray[2].ToString() == "Préventive Syst Compteur";
				if (flag6)
				{
					text = "PSC";
				}
				bool flag7 = dataTable.Rows[0].ItemArray[2].ToString() == "Préventive Conditionnelle";
				if (flag7)
				{
					text = "PCN";
				}
				int num = dataTable6.Rows.Count + 1;
				string text3 = string.Concat(new string[]
				{
					text,
					"-",
					DateTime.Today.Year.ToString(),
					"-",
					DateTime.Today.Month.ToString(),
					"-",
					num.ToString()
				});
				int num2 = Convert.ToInt32(dataTable.Rows[0].ItemArray[6]);
				sqlCommand6.Parameters.Add("@i1", SqlDbType.VarChar).Value = text3;
				sqlCommand6.Parameters.Add("@i2", SqlDbType.Int).Value = 0;
				sqlCommand6.Parameters.Add("@i3", SqlDbType.Date).Value = DateTime.Today;
				sqlCommand6.Parameters.Add("@i4", SqlDbType.VarChar).Value = fonction.Mid(DateTime.Now.TimeOfDay.ToString(), 1, 5);
				sqlCommand6.Parameters.Add("@i5", SqlDbType.Date).Value = DateTime.Today;
				sqlCommand6.Parameters.Add("@i6", SqlDbType.VarChar).Value = fonction.Mid(DateTime.Now.TimeOfDay.ToString(), 1, 5);
				sqlCommand6.Parameters.Add("@i7", SqlDbType.VarChar).Value = dataTable.Rows[0].ItemArray[0].ToString();
				sqlCommand6.Parameters.Add("@i8", SqlDbType.Int).Value = id_gamme;
				sqlCommand6.Parameters.Add("@i9", SqlDbType.VarChar).Value = dataTable.Rows[0].ItemArray[1].ToString();
				sqlCommand6.Parameters.Add("@i10", SqlDbType.VarChar).Value = dataTable.Rows[0].ItemArray[2].ToString();
				sqlCommand6.Parameters.Add("@i11", SqlDbType.Int).Value = dataTable.Rows[0].ItemArray[3].ToString();
				sqlCommand6.Parameters.Add("@i13", SqlDbType.Int).Value = dataTable.Rows[0].ItemArray[5].ToString();
				sqlCommand6.Parameters.Add("@i14", SqlDbType.VarChar).Value = "";
				sqlCommand6.Parameters.Add("@i15", SqlDbType.Int).Value = page_loginn.id_user;
				sqlCommand6.Parameters.Add("@i16", SqlDbType.Int).Value = 0;
				sqlCommand6.Parameters.Add("@i17", SqlDbType.Int).Value = atelier;
				sqlCommand6.Parameters.Add("@i18", SqlDbType.Int).Value = equipement;
				sqlCommand6.Parameters.Add("@i19", SqlDbType.Int).Value = sous_equipement;
				sqlCommand6.Parameters.Add("@i20", SqlDbType.Int).Value = organe;
				sqlCommand6.Parameters.Add("@i21", SqlDbType.Int).Value = 0;
				sqlCommand6.Parameters.Add("@i22", SqlDbType.DateTime).Value = DateTime.Now;
				sqlCommand6.Parameters.Add("@i23", SqlDbType.DateTime).Value = DateTime.Now.AddMinutes((double)num2);
				bd.ouverture_bd(bd.cnn);
				int num3 = (int)sqlCommand6.ExecuteScalar();
				bd.cnn.Close();
				string cmdText8 = "select designation from equipement where id = @i";
				SqlCommand sqlCommand8 = new SqlCommand(cmdText8, bd.cnn);
				sqlCommand8.Parameters.Add("@i", SqlDbType.Int).Value = equipement;
				SqlDataAdapter sqlDataAdapter7 = new SqlDataAdapter(sqlCommand8);
				DataTable dataTable7 = new DataTable();
				sqlDataAdapter7.Fill(dataTable7);
				string text4 = "";
				bool flag8 = dataTable7.Rows.Count != 0;
				if (flag8)
				{
					text4 = Convert.ToString(dataTable7.Rows[0].ItemArray[0]);
				}
				string cmdText9 = "select designation from equipement_compteur where id = @i";
				SqlCommand sqlCommand9 = new SqlCommand(cmdText9, bd.cnn);
				sqlCommand9.Parameters.Add("@i", SqlDbType.Int).Value = id_compteur;
				SqlDataAdapter sqlDataAdapter8 = new SqlDataAdapter(sqlCommand9);
				DataTable dataTable8 = new DataTable();
				sqlDataAdapter8.Fill(dataTable8);
				string text5 = "";
				bool flag9 = dataTable8.Rows.Count != 0;
				if (flag9)
				{
					text5 = Convert.ToString(dataTable8.Rows[0].ItemArray[0]);
				}
				string cmdText10 = "select mesure from prev_conditionnelle where id = @i";
				SqlCommand sqlCommand10 = new SqlCommand(cmdText10, bd.cnn);
				sqlCommand10.Parameters.Add("@i", SqlDbType.Int).Value = id_mesure;
				SqlDataAdapter sqlDataAdapter9 = new SqlDataAdapter(sqlCommand10);
				DataTable dataTable9 = new DataTable();
				sqlDataAdapter9.Fill(dataTable9);
				string text6 = "";
				bool flag10 = dataTable9.Rows.Count != 0;
				if (flag10)
				{
					text6 = Convert.ToString(dataTable9.Rows[0].ItemArray[0]);
				}
				bool flag11 = dataTable.Rows[0].ItemArray[2].ToString() == "Préventive Syst Compteur";
				if (flag11)
				{
					description = string.Concat(new string[]
					{
						"Le Système à lancer un OT Prév.Syst Compteur : ",
						text2,
						" le ",
						DateTime.Now.ToString(),
						" de ID = ",
						num3.ToString(),
						" de N° ",
						text3,
						" pour l'équipement ",
						text4,
						" pour le compteur ",
						text5,
						" lorsque il atteint la valeur ",
						vlr_compteur.ToString()
					});
				}
				bool flag12 = dataTable.Rows[0].ItemArray[2].ToString() == "Préventive Conditionnelle";
				if (flag12)
				{
					description = string.Concat(new string[]
					{
						"Le Système à lancer un OT Prév.Conditionnelle : ",
						text2,
						" le ",
						DateTime.Now.ToString(),
						" de ID = ",
						num3.ToString(),
						" de N° ",
						text3,
						" pour l'équipement ",
						text4,
						" pour la mesure ",
						text6,
						" lorsque il atteint la valeur ",
						vlr_mesure.ToString()
					});
				}
				lancement_ot_preventive.insert_notification(num3, "Lancement OT Prév", description, DateTime.Today);
				for (int i = 0; i < dataTable5.Rows.Count; i++)
				{
					string cmdText11 = "insert into ot_centre_charge (id_ot, id_centre_charge) values (@i1, @i2)";
					SqlCommand sqlCommand11 = new SqlCommand(cmdText11, bd.cnn);
					sqlCommand11.Parameters.Add("@i1", SqlDbType.Int).Value = num3;
					sqlCommand11.Parameters.Add("@i2", SqlDbType.Int).Value = dataTable5.Rows[i].ItemArray[0].ToString();
					bd.ouverture_bd(bd.cnn);
					sqlCommand11.ExecuteNonQuery();
					bd.cnn.Close();
				}
				bool flag13 = dataTable2.Rows.Count != 0;
				if (flag13)
				{
					for (int j = 0; j < dataTable2.Rows.Count; j++)
					{
						string cmdText12 = "insert into ot_ressources_fonction (id_fonction, id_ot, nbre_requis, min_planif, type_cout, date_debut, heure_debut) values (@i1, @i2, @i3, @i4, @i5, @i6, @i7)";
						SqlCommand sqlCommand12 = new SqlCommand(cmdText12, bd.cnn);
						sqlCommand12.Parameters.Add("@i1", SqlDbType.Int).Value = dataTable2.Rows[j].ItemArray[0];
						sqlCommand12.Parameters.Add("@i2", SqlDbType.Int).Value = num3;
						sqlCommand12.Parameters.Add("@i3", SqlDbType.Int).Value = dataTable2.Rows[j].ItemArray[1];
						sqlCommand12.Parameters.Add("@i4", SqlDbType.Int).Value = dataTable2.Rows[j].ItemArray[2];
						sqlCommand12.Parameters.Add("@i5", SqlDbType.VarChar).Value = dataTable2.Rows[j].ItemArray[3];
						sqlCommand12.Parameters.Add("@i6", SqlDbType.Date).Value = DateTime.Today;
						sqlCommand12.Parameters.Add("@i7", SqlDbType.VarChar).Value = DateTime.Now.TimeOfDay.ToString();
						bd.ouverture_bd(bd.cnn);
						sqlCommand12.ExecuteNonQuery();
						bd.cnn.Close();
					}
				}
				bool flag14 = dataTable3.Rows.Count != 0;
				if (flag14)
				{
					for (int k = 0; k < dataTable3.Rows.Count; k++)
					{
						string cmdText13 = "insert into ot_ressources_outil (id_type, id_ot,date_sh, quantite) values (@i1, @i2, @i3, @i4)";
						SqlCommand sqlCommand13 = new SqlCommand(cmdText13, bd.cnn);
						sqlCommand13.Parameters.Add("@i1", SqlDbType.Int).Value = dataTable3.Rows[k].ItemArray[0];
						sqlCommand13.Parameters.Add("@i2", SqlDbType.Int).Value = num3;
						sqlCommand13.Parameters.Add("@i3", SqlDbType.DateTime).Value = DateTime.Now;
						sqlCommand13.Parameters.Add("@i4", SqlDbType.Int).Value = dataTable3.Rows[k].ItemArray[1];
						bd.ouverture_bd(bd.cnn);
						sqlCommand13.ExecuteNonQuery();
						bd.cnn.Close();
					}
				}
				bool flag15 = dataTable4.Rows.Count != 0;
				if (flag15)
				{
					for (int l = 0; l < dataTable4.Rows.Count; l++)
					{
						string cmdText14 = "insert into ot_ressources_pdr (id_article, id_ot,date_sh, quantite) values (@i1, @i2, @i3, @i4)";
						SqlCommand sqlCommand14 = new SqlCommand(cmdText14, bd.cnn);
						sqlCommand14.Parameters.Add("@i1", SqlDbType.Int).Value = dataTable4.Rows[l].ItemArray[0];
						sqlCommand14.Parameters.Add("@i2", SqlDbType.Int).Value = num3;
						sqlCommand14.Parameters.Add("@i3", SqlDbType.DateTime).Value = DateTime.Now;
						sqlCommand14.Parameters.Add("@i4", SqlDbType.Int).Value = dataTable4.Rows[l].ItemArray[1];
						bd.ouverture_bd(bd.cnn);
						sqlCommand14.ExecuteNonQuery();
						bd.cnn.Close();
					}
				}
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000FF1FC File Offset: 0x000FD3FC
		public static void creation_ot_mesure(int id_mesure, double valeur)
		{
			bd bd = new bd();
			string cmdText = "select id_gamme,valeur_lancement, type_valeur, atelier, equipement,sous_equipement, organe from prev_conditionnelle where prev_conditionnelle.id = @i and arr = @a";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_mesure;
			sqlCommand.Parameters.Add("@a", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string a = dataTable.Rows[i].ItemArray[2].ToString();
					int id_gamme = Convert.ToInt32(dataTable.Rows[i].ItemArray[0]);
					double num = Convert.ToDouble(dataTable.Rows[i].ItemArray[1]);
					int atelier = Convert.ToInt32(dataTable.Rows[i].ItemArray[3]);
					int equipement = Convert.ToInt32(dataTable.Rows[i].ItemArray[4]);
					int sous_equipement = Convert.ToInt32(dataTable.Rows[i].ItemArray[5]);
					int organe = Convert.ToInt32(dataTable.Rows[i].ItemArray[6]);
					int num2 = 0;
					bool flag2 = a == "Sup";
					if (flag2)
					{
						bool flag3 = valeur >= num;
						if (flag3)
						{
							num2 = 1;
						}
					}
					bool flag4 = a == "Inf";
					if (flag4)
					{
						bool flag5 = valeur <= num;
						if (flag5)
						{
							num2 = 1;
						}
					}
					bool flag6 = num2 == 1;
					if (flag6)
					{
						lancement_ot_preventive.creation_ressource_ot(id_gamme, atelier, equipement, sous_equipement, organe, 0, 0.0, id_mesure, valeur);
					}
				}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000FF3F8 File Offset: 0x000FD5F8
		private static void insert_notification(int id_n, string type_n, string description, DateTime date_creation)
		{
			bd bd = new bd();
			string cmdText = "select id from utilisateur where (fonction = @a2 or fonction = @a3 or fonction = @a4 or fonction = @a5 or fonction = @a6) and deleted = @d";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@a2", SqlDbType.VarChar).Value = "Ingénieur Méthode";
			sqlCommand.Parameters.Add("@a3", SqlDbType.VarChar).Value = "Responsable Technique";
			sqlCommand.Parameters.Add("@a4", SqlDbType.VarChar).Value = "Responsable Maintenance";
			sqlCommand.Parameters.Add("@a5", SqlDbType.VarChar).Value = "Responsable Méthode";
			sqlCommand.Parameters.Add("@a6", SqlDbType.VarChar).Value = "Agent de Méthode";
			sqlCommand.Parameters.Add("@d", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				int num = Convert.ToInt32(dataTable.Rows[i].ItemArray[0]);
				string cmdText2 = "insert into notification (id_n, type, id_utilisateur, description, vue, date_creation) values (@v1, @v2, @v3, @v4, @v5, @v6)";
				SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
				sqlCommand2.Parameters.Add("@v1", SqlDbType.Int).Value = id_n;
				sqlCommand2.Parameters.Add("@v2", SqlDbType.VarChar).Value = type_n;
				sqlCommand2.Parameters.Add("@v3", SqlDbType.Int).Value = num;
				sqlCommand2.Parameters.Add("@v4", SqlDbType.VarChar).Value = description;
				sqlCommand2.Parameters.Add("@v5", SqlDbType.Int).Value = 0;
				sqlCommand2.Parameters.Add("@v6", SqlDbType.Date).Value = date_creation;
				bd.ouverture_bd(bd.cnn);
				sqlCommand2.ExecuteNonQuery();
				bd.cnn.Close();
			}
		}
	}
}
