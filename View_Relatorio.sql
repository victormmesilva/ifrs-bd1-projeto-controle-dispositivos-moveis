
use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;

create view view_relatorio as 
	select 'QT DOS APARELHOS'	AS 'RELATORIO',
	COUNT(*) from TBT_APARELHOS  union
    select 	'QT DOS BAIRROS',
	COUNT(*) from TBT_BAIRROS union
    select 	'QT DOS CARGOS',
	COUNT(*) from TBT_CARGOS union
    select 	'QT DAS CIDADES',
	COUNT(*) from TBT_CIDADES union
    select 	'QT DOS ESTADOS',
	COUNT(*) from TBT_ESTADOS union
    select 	'QT DA FILA DE ESPERA',
	COUNT(*) from TBT_FILA_DE_ESPERA union
    select 	'QT DOS FUNCIONARIOS TOTAIS',
	COUNT(*) from TBT_FUNCIONARIOS union
    select 	'QT DOS FUNCIONARIOS COM APARELHO',
	COUNT(*) from TBT_FUNCIONARIOS_APARELHOS union
    select 	'QT DOS GENEROS',
	COUNT(*) from TBT_GENEROS union
    select 	'QT DAS LINHAS TELEFONICAS',
	COUNT(*) from TBT_LINHAS_TELEFONICAS union
    select 	'QT DAS MARCAS DE CELULAR',
	COUNT(*) from TBT_MARCAS_DE_CELULAR union
    select 	'QT DOS MODELOS DE CELULAR',
	COUNT(*) from TBT_MODELOS_DE_CELULAR union
    select 	'QT DAS OPERADOS TELEFONICAS',
	COUNT(*) from TBT_OPERADORAS_TELEFONICAS union
    select 	'QT DOS PAISES',
	COUNT(*) from TBT_PAISES union
    select 	'QT DAS RUAS',
	COUNT(*) from TBT_RUAS union
    select 	'QT TELEFONES DOS FUNCIONARIOS',
	COUNT(*) from TBT_TELEFONES_FUNCIONARIOS union
    select 	'QT DOS TIPOS DE CHIP',
	COUNT(*) from TBT_TIPOS_DE_CHIP
  



 
