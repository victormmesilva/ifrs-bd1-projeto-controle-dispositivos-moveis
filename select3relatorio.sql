use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;

select 'QT do Funcionário'	AS 'RELATORIO',
COUNT(*) from TBT_FUNCIONARIOS union
select 	'QT do aparelhos',
COUNT(*) from TBT_APARELHOS  union
select 	'QT PAISES',
COUNT(*) from tbt_paises union
select 	'QT CIDADE',
COUNT(*) from tbt_cidades union
select 	'QT ESTADOS',
COUNT(*) from tbt_estados  union
select 	'QT LINHAS',
COUNT(*) from tbt_linhas_telefonicas  union
select 	'QT BAIRROS',
COUNT(*) from tbt_bairros  union
select 	'QT CARGOS',
COUNT(*) from tbt_cargos union
select 	'QT MARCAS DE CELULAR',
COUNT(*) from tbt_marcas_de_celular union
select 	'QT MODELOS',
COUNT(*) from tbt_modelos_de_celular union
select 	'QT OPERADORAS',
COUNT(*) from tbt_operadoras_telefonicas union
select 	'QT TIPOS DE CHIP',
COUNT(*) from tbt_tipos_de_chip  
  
 
 
 






