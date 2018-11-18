/*CREATE
    [DEFINER = { user | CURRENT_USER }]
    TRIGGER trigger_name
    trigger_time trigger_event
    ON tbl_name FOR EACH ROW
    [trigger_order]
    trigger_body

trigger_time: { BEFORE | AFTER }

trigger_event: { INSERT | UPDATE | DELETE }

trigger_order: { FOLLOWS | PRECEDES } other_trigger_name */


USE projeto_controle_de_dispositivos_moveis;
CREATE TRIGGER trigger_verifica_fila
AFTER INSERT 
ON tbt_aparelhos FOR EACH ROW 
CALL pro_verifica_lista_de_espera