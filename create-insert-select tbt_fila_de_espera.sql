USE projeto_controle_de_dispositivos_moveis;

CREATE TABLE tbt_fila_de_espera(
	posicao INT NOT NULL AUTO_INCREMENT,
    id_funcionario INT NOT NULL,
    id_modelo INT NOT NULL,
    em_espera BOOL NOT NULL,
    
    PRIMARY KEY(posicao),
    FOREIGN KEY(id_funcionario) REFERENCES tbt_funcionarios(id_funcionario),
	FOREIGN KEY(id_modelo) REFERENCES tbt_modelos_de_celular(id_modelo)
);

INSERT INTO tbt_fila_de_espera(posicao,id_funcionario,id_modelo,em_espera)
VALUES (null,5,11,1);

INSERT INTO tbt_fila_de_espera(posicao,id_funcionario,id_modelo,em_espera)
VALUES (null,4,4,1);

INSERT INTO tbt_fila_de_espera(posicao,id_funcionario,id_modelo,em_espera)
VALUES (null,9,4,1);

SELECT 	fila.posicao,
		func.id_funcionario,
		func.nome_completo,
        model.ID_MODELO,
        model.nome_modelo,
        CASE 
			WHEN fila.em_espera = 1 THEN 'SIM'       
			WHEN fila.em_espera = 0 THEN 'NÃO'  
        END AS 'Em espera'
FROM tbt_fila_de_espera fila
INNER JOIN tbt_funcionarios func
ON fila.id_funcionario = func.id_funcionario
INNER JOIN tbt_modelos_de_celular model
ON fila.id_modelo = model.id_modelo;

