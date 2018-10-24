
use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;

create view view_relatorio as 
	select 'QT do Funcionário'	AS 'RELATORIO',
	COUNT(*) from TBT_FUNCIONARIOS union
	select 	'QT do aparelhos',
	COUNT(*) from TBT_APARELHOS  union
	select 	'QT PAISES',
	COUNT(*) from TBT_PAISES union
	select 	'QT CIDADE',
	COUNT(*) from TBT_CIDADES union
	select 	'QT ESTADOS',
	COUNT(*) from TBT_ESTADOS  union
	select 	'QT LINHAS',
	COUNT(*) from TBT_LINHAS_TELEFONICAS  union
	select 	'QT BAIRROS',
	COUNT(*) from TBT_BAIRROS  union
	select 	'QT CARGOS',
	COUNT(*) from TBT_CARGOS union
	select 	'QT MARCAS DE CELULAR',
	COUNT(*) from TBT_MARCAS_DE_CELULAR union
	select 	'QT MODELOS',
	COUNT(*) from TBT_MODELOS_DE_CELULAR union
	select 	'QT OPERADORAS',
	COUNT(*) from TBT_OPERADORAS_TELEFONICAS union
	select 	'QT TIPOS DE CHIP',
	COUNT(*) from TBT_TIPOS_DE_CHIP  
  



 