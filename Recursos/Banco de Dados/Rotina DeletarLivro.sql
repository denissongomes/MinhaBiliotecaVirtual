DELIMITER //
CREATE PROCEDURE `DeletarLivro`(
p_LivroId int)
BEGIN
delete from Livro where LivroId=p_LivroId;
END;
//

DELIMITER ;