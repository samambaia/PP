select resultado.*, (resultado.minimo - (resultado.saldo + resultado.entrada_saida)) as sugestao
from
(
select
      estoq.id_embalagem,
      estoq.id_armazenagem,
      estoq.id_produto,
      estoq.descricao,
      estoq.efetivo,
      case when estoq.qtd_transito is null then 0 else estoq.qtd_transito
      end transito,
      case when estoq.qtd_romaneio is null then 0 else estoq.qtd_romaneio
      end romaneio,
      (estoq.efetivo - (
                        case when estoq.qtd_transito is null then 0 else estoq.qtd_transito
                        end +
                        case when estoq.qtd_romaneio is null then 0 else estoq.qtd_romaneio
                        end)) saldo,
      (case when estoq.qtd_entrada is null then 0 else estoq.qtd_entrada
       end - case when estoq.qtd_saida is null then 0 else estoq.qtd_saida
       end) entrada_saida,
      estoq.minimo
from 
(
    SELECT
      ESTOK.id_embalagem,
      ESTOK.id_armazenagem,
      dbo.PRODUTOS.id_produto,
      dbo.PRODUTOS.descricao,
      ESTOK.efetivo,
      (
        /* Quantidade EM TRANSITO */
        select rom.romaneio
        from
        (
          select soma.id_produto, sum(soma.romaneio) romaneio from
          (
              select calc.*,
              (calc.qtd_emb_sel / calc.qtd_emb_principal) * calc.quantidade romaneio
              from
              (
                select
                   sel.*,
                   cast(embalagem.qtd_emb as decimal(12,4)) as qtd_emb_principal
                from
                (
                    /* Quantidade embalagem selecionada */
                    select distinct SAIDA.id_saida, ITENS_SAIDA.id_embalagem,
                           EMBALAGEM.id_produto, ITENS_SAIDA.quantidade,
                           cast(EMBALAGEM.qtd_emb as decimal(12,4)) QTD_EMB_SEL
                     from SAIDA, ITENS_SAIDA, EMBALAGEM, ESTOQUE
                    where SAIDA.id_saida = ITENS_SAIDA.id_saida
                      and ITENS_SAIDA.id_embalagem = embalagem.id_embalagem
                      and SAIDA.efetivado = 3
                      and SAIDA.id_armazenagem = ESTOK.id_armazenagem
                      and ITENS_SAIDA.id_embalagem = ESTOK.id_embalagem
                ) sel, embalagem
                where sel.id_produto = embalagem.id_produto
                  and embalagem.principal = 1
                ) calc
          ) soma
          group by id_produto
        ) rom
      ) qtd_transito,
      
      (
        /* Quantidade EM ROMANEIO */
        select rom.romaneio
        from
        (
          select soma.id_produto, sum(soma.romaneio) romaneio from
          (
              select calc.*,
              (calc.qtd_emb_sel / calc.qtd_emb_principal) * calc.quantidade romaneio
              from
              (
                select
                   sel.*,
                   cast(embalagem.qtd_emb as decimal(12,4)) as qtd_emb_principal
                from
                (
                    /* Quantidade embalagem selecionada */
                    select distinct SAIDA.id_saida, ITENS_SAIDA.id_embalagem,
                           EMBALAGEM.id_produto, ITENS_SAIDA.quantidade,
                           cast(EMBALAGEM.qtd_emb as decimal(12,4)) QTD_EMB_SEL
                     from SAIDA, ITENS_SAIDA, EMBALAGEM, ESTOQUE
                    where SAIDA.id_saida = ITENS_SAIDA.id_saida
                      and ITENS_SAIDA.id_embalagem = embalagem.id_embalagem
                      and SAIDA.efetivado = 4
                      and SAIDA.id_armazenagem = ESTOK.id_armazenagem
                      and ITENS_SAIDA.id_embalagem = ESTOK.id_embalagem
                ) sel, embalagem
                where sel.id_produto = embalagem.id_produto
                  and embalagem.principal = 1
                ) calc
          ) soma
          group by id_produto
        ) rom
      ) qtd_romaneio,
      
      (
        /* Quantidade ENTRADA */
        select rom.romaneio
        from
        (
          select soma.id_produto, sum(soma.romaneio) romaneio from
          (
              select calc.*,
              (calc.qtd_emb_sel / calc.qtd_emb_principal) * calc.quantidade romaneio
              from
              (
                select
                   sel.*,
                   cast(embalagem.qtd_emb as decimal(12,4)) as qtd_emb_principal
                from
                (
                    /* Quantidade embalagem selecionada */
                    select distinct ENTRADA.ID_ENTRADA, ITENS_ENTRADA.id_embalagem,
                           EMBALAGEM.id_produto, ITENS_ENTRADA.quantidade,
                           cast(EMBALAGEM.qtd_emb as decimal(12,4)) QTD_EMB_SEL
                     from ENTRADA, ITENS_ENTRADA, EMBALAGEM, ESTOQUE
                    where ENTRADA.id_entrada = ITENS_ENTRADA.id_entrada
                      and ITENS_ENTRADA.id_embalagem = embalagem.id_embalagem
                      and ENTRADA.efetivado = 0
                      and ENTRADA.id_armazenagem = ESTOK.id_armazenagem
                      and ITENS_ENTRADA.id_embalagem = ESTOK.id_embalagem
                ) sel, embalagem
                where sel.id_produto = embalagem.id_produto
                  and embalagem.principal = 1
                ) calc
          ) soma
          group by id_produto
        ) rom
      ) qtd_entrada,

      (
        /* Quantidade SAIDA */
        select rom.romaneio
        from
        (
          select soma.id_produto, sum(soma.romaneio) romaneio from
          (
              select calc.*,
              (calc.qtd_emb_sel / calc.qtd_emb_principal) * calc.quantidade romaneio
              from
              (
                select
                   sel.*,
                   cast(embalagem.qtd_emb as decimal(12,4)) as qtd_emb_principal
                from
                (
                    /* Quantidade embalagem selecionada */
                    select distinct SAIDA.id_saida, ITENS_SAIDA.id_embalagem,
                           EMBALAGEM.id_produto, ITENS_SAIDA.quantidade,
                           cast(EMBALAGEM.qtd_emb as decimal(12,4)) QTD_EMB_SEL
                     from SAIDA, ITENS_SAIDA, EMBALAGEM, ESTOQUE
                    where SAIDA.id_saida = ITENS_SAIDA.id_saida
                      and ITENS_SAIDA.id_embalagem = embalagem.id_embalagem
                      and SAIDA.efetivado = 0
                      and SAIDA.id_armazenagem = ESTOK.id_armazenagem
                      and ITENS_SAIDA.id_embalagem = ESTOK.id_embalagem
                ) sel, embalagem
                where sel.id_produto = embalagem.id_produto
                  and embalagem.principal = 1
                ) calc
          ) soma
          group by id_produto
        ) rom
      ) qtd_saida,

      ESTOK.minimo,
      dbo.EMBALAGEM.unidade,
      dbo.EMBALAGEM.qtd_emb,
      dbo.LINHA_PROD.id_linha_prod,
      dbo.PESSOA.id_pessoa
    FROM
      dbo.ESTOQUE as ESTOK
      INNER JOIN dbo.EMBALAGEM ON (ESTOK.id_embalagem = dbo.EMBALAGEM.id_embalagem)
      INNER JOIN dbo.PRODUTOS ON (dbo.EMBALAGEM.id_produto = dbo.PRODUTOS.id_produto)
      LEFT OUTER JOIN dbo.PESSOA ON (dbo.PRODUTOS.id_fabrica = dbo.PESSOA.id_pessoa)
      LEFT OUTER JOIN dbo.LINHA_PROD ON (dbo.PRODUTOS.id_linha_prod = dbo.LINHA_PROD.id_linha_prod)
    WHERE (PRODUTOS.status = 1 OR ESTOK.efetivo > 0)
) estoq
) resultado
