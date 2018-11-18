DELIMITER $$
CREATE PROCEDURE pro_verifica_lista_de_espera()
BEGIN
	DECLARE var_id_aparelho INT UNSIGNED DEFAULT 0;     
    DECLARE var_id_modelo INT UNSIGNED DEFAULT 0;
    DECLARE var_id_funcionario INT UNSIGNED DEFAULT 0;    
    
    /*PEGA O ID DO ULTIMO APARELHO INSERIDO*/
	SET @var_id_aparelho = (	SELECT MAX(id_aparelho) 
								FROM tbt_aparelhos);
    
    /*PEGA O MODELO DO APARELHO*/
    SET @var_id_modelo = (	SELECT fk_id_modelo 
							FROM tbt_aparelhos 
                            WHERE id_aparelho = @var_id_aparelho);   
    
    
    /*PEGA O ID DO FUNCIONARIO QUE ESTA ESPERANDO O APARELHO DAQUELE MODELO*/
    SET @var_id_funcionario = (	SELECT id_funcionario 
								FROM tbt_fila_de_espera 
								WHERE posicao = (	SELECT MIN(posicao) 
													FROM tbt_fila_de_espera 
													WHERE id_modelo = @var_id_modelo));    
    UPDATE tbt_aparelhos
    SET fk_id_funcionario = @var_id_funcionario
    WHERE id_aparelho = @var_id_aparelho;       
    
END $$
DELIMITER ;