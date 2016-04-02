        public void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a impressão da Nota Fiscal?", "Nota Fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                this.btnGravar_Click(sender, e);
                ImprimeTexto imp = new ImprimeTexto();

                SqlDataReader drImpNF = this.Saida.Imp_NF(this.Saida.id_saida);
                if (drImpNF.HasRows)
                {
                    drImpNF.Read();
                    if (imp.Inicio(@"\\PP02\LX300"))
                    {
                        decimal vlr;
                        imp.Imp(imp.Comprimido);
                        imp.Pula(6);
                        string semAcento = this.fg.remove_acentos(drImpNF["desc_cfop"].ToString());
                        imp.ImpCol(7, semAcento);
                        imp.ImpCol(35, drImpNF["id_cfop"].ToString());
                        imp.Pula(2);
                        semAcento = this.fg.remove_acentos(drImpNF["razao_social"].ToString().ToUpper());
                        imp.ImpCol(7, semAcento);
                        imp.ImpCol(94, drImpNF["cpf_cnpj"].ToString());
                        string dataConv = Convert.ToDateTime(drImpNF["data_emissao"].ToString()).ToShortDateString();
                        imp.ImpCol(0x79, dataConv);
                        imp.Pula(1);
                        semAcento = this.fg.remove_acentos(drImpNF["endereco"].ToString().ToUpper());
                        imp.ImpCol(7, semAcento);
                        semAcento = this.fg.remove_acentos(drImpNF["bairro"].ToString().ToUpper());
                        imp.ImpCol(75, semAcento);
                        imp.ImpCol(101, drImpNF["cep"].ToString());
                        imp.Pula(2);
                        semAcento = this.fg.remove_acentos(drImpNF["cidade"].ToString().ToUpper());
                        imp.ImpCol(7, semAcento);
                        imp.ImpCol(63, drImpNF["telefone"].ToString());
                        imp.ImpCol(88, drImpNF["uf"].ToString());
                        imp.ImpCol(95, drImpNF["ie"].ToString());
                        imp.Pula(3);
                        int Ln = 0;
                        SqlDataReader drImpItensNF = this.Saida.Imp_NF(this.Saida.id_saida, 1);
                        imp.Imp(imp.Comprimido);
                        if (drImpItensNF.HasRows)
                        {
                            while (drImpItensNF.Read())
                            {
                                imp.ImpCol(7, drImpItensNF["id_produto"].ToString());
                                semAcento = this.fg.remove_acentos(drImpItensNF["descricao"].ToString());
                                imp.ImpCol(14, semAcento);
                                imp.ImpCol(77, "00");
                                semAcento = this.fg.remove_acentos(drImpItensNF["unidade"].ToString().Trim());
                                imp.ImpCol(83, semAcento);
                                vlr = Convert.ToDecimal(drImpItensNF["quantidade"].ToString());
                                imp.ImpCol(90, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                vlr = Convert.ToDecimal(drImpItensNF["valor_unitario"].ToString());
                                imp.ImpCol(101, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                vlr = Convert.ToDecimal(drImpItensNF["total_item"].ToString());
                                imp.ImpCol(116, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                imp.ImpColLF(129, "**".PadLeft(5, ' '));
                                Ln++;
                            }
                        }
                        SqlDataReader drImpTotDescNF = this.Saida.Tot_Desc_NF(this.Saida.id_saida, 1);
                        drImpTotDescNF.Read();
                        if (decimal.Parse(drImpTotDescNF["total_desc"].ToString()) > 0)
                        {
                            vlr = Convert.ToDecimal(drImpTotDescNF["total_desc"].ToString());
                            imp.ImpCol(90, "TOTAL DO DESCONTO: ");
                            imp.ImpCol(116, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            Ln++;
                        }
                        else
                        {
                            vlr = Convert.ToDecimal(drImpTotDescNF["total_desc"].ToString());
                            imp.ImpCol(90, "");
                            Ln++;
                        }

                        Ln = 23 - Ln;

                        //Ln += 14;

                        SqlDataReader drImpNFTot = this.Saida.Imp_NF_Totais(this.Saida.id_saida);
                        imp.Imp(imp.Normal);
                        imp.Imp(imp.NegritoOn);
                        drImpNFTot.Read();
                        imp.Pula(Ln);
                        vlr = Convert.ToDecimal(drImpNFTot["total_nf"].ToString()) - Tot_Serv;
                        imp.ImpCol(65, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                        imp.Pula(1);
                        vlr = Convert.ToDecimal(drImpNFTot["total_nf"].ToString());
                        imp.ImpCol(65, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                        imp.Imp(imp.NegritoOff);
                        imp.Pula(2);
                        if (drImpNF["frete_pc"].ToString() == "1")
                        {
                            imp.ImpCol(5, "O MESMO");
                            imp.ImpCol(53, "1");
                            imp.Pula(4);
                            imp.Imp(imp.NegritoOn);
                        }
                        else
                        {
                            imp.Imp(imp.Comprimido);
                            semAcento = this.fg.remove_acentos(drImpNF["nome_razao"].ToString());
                            imp.ImpCol(5, semAcento);
                            imp.ImpCol(70, "2");
                            imp.ImpCol(78, drImpNF["placa"].ToString());
                            imp.ImpCol(102, drImpNF["uf_placa"].ToString());
                            imp.ImpCol(113, drImpNF["cpf_cnpj_transp"].ToString());
                            imp.Pula(2);
                            semAcento = this.fg.remove_acentos(drImpNF["endereco_transp"].ToString());
                            imp.ImpCol(5, semAcento);
                            imp.ImpCol(60, drImpNF["municipio"].ToString());
                            imp.ImpCol(102, drImpNF["uf_transp"].ToString());
                            imp.ImpCol(113, drImpNF["insc_estadual"].ToString());
                            imp.Pula(1);
                            imp.ImpCol(5, drImpNF["qtd_transp"].ToString());
                            imp.ImpCol(20, drImpNF["especie"].ToString());
                            imp.Pula(2);
                            imp.Imp(imp.NegritoOn);
                        }
                        imp.Imp(imp.NegritoOff);
                        imp.Pula(2);
                        imp.Imp(imp.Comprimido);
                        imp.ImpColLF(10, "ESTA EMPRESA ESTA CADASTRADA NO SIMPLES NACIONAL,");
                        imp.ImpCol(10, "CONFORME LEI COMPLEMENTAR No.123 DE 2006");
                        imp.Imp(imp.Normal);
                        imp.Imp(imp.NegritoOn);
                        dataConv = Convert.ToDateTime(drImpNF["data_emissao"].ToString()).ToShortDateString();
                        imp.ImpCol(60, dataConv);
                        imp.Pula(1);
                        imp.ImpCol(60, drImpNF["selo"].ToString());
                        imp.Imp(imp.NegritoOff);
                        imp.Imp(imp.Comprimido);
                        semAcento = this.fg.remove_acentos(drImpNF["obs"].ToString());
                        imp.ImpColLF(10, "OBS: " + semAcento);
                        imp.ImpCol(10, "     " + this.fg.remove_acentos(drImpNF["obs2"].ToString()));
                        imp.Imp(imp.Normal);
                        imp.Eject();
                        imp.Fim();
                        MessageBox.Show("Enviado para a Impressora!", "Impressão de NF");
                    }
                    else
                    {
                        MessageBox.Show("Erro na Impressora. Verifique a conexão!", "Impressão de NF");
                    }
                }
            }
        }

         

         
