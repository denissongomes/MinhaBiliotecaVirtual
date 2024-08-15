CREATE DEFINER=`root`@`%` PROCEDURE `CriarLivro`(
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
if not exists (select * from Livro where Titulo = p_Titulo) then
INSERT INTO Livro (Titulo, ISBN, EditoraId, AutorId, CategoriaId)
VALUES
(
p_Titulo,
p_ISBN,
(select EditoraId from Editora where EditoraNome=p_EditoraNome),
(select AutorId from Autor where AutorNome=p_AutorNome),
(select CategoriaId from Categoria where CategoriaNome=p_CategoriaNome)
);
end if;
END