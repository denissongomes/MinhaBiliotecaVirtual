CREATE DEFINER=`root`@`%` PROCEDURE `AtualizarLivro`(
p_LivroId int,
p_Titulo varchar(50),
p_ISBN varchar(20),
p_EditoraNome varchar(50),
p_AutorNome varchar(50),
p_CategoriaNome varchar(50))
BEGIN
if not exists (select * from Categoria where CategoriaNome = p_CategoriaNome) then
INSERT INTO Categoria (CategoriaNome) VALUES (p_CategoriaNome);
end if;
if not exists (select * from Autor where AutorNome = p_AutorNome) then
INSERT INTO Autor (AutorNome) VALUES (p_AutorNome);
end if;
if not exists (select * from Editora where EditoraNome = p_EditoraNome) then
INSERT INTO Editora (EditoraNome) VALUES (p_EditoraNome);
end if;
UPDATE Livro SET
Titulo = p_Titulo,
ISBN = p_ISBN,
EditoraId = (select EditoraId from Editora where EditoraNome = p_EditoraNome),
AutorId = (select AutorId from Autor where AutorNome = p_AutorNome),
CategoriaId = (select CategoriaId from Categoria where CategoriaNome = p_CategoriaNome)
WHERE LivroId = p_LivroId;
END