Crie o banco de dados empresa_db por meio do SQL Server Management Studio.

Nele, crie tamb�m as tabelas:

        departamento(idDepartamento,nome,localizacao,orcamento)
        idDepartamento chave prim�ria

        empregado(idEmpregado,nome,idGerente,funcao,idDepartamento,dataAdmissao,salario,comissao)
        idEmpregado chave prim�ria 
        idDepartamento referencia departamento 
        idGerente referencia empregado

Ap�s, insere nas tabelas os seguintes valores:

--inserindo dados nas tabelas
INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('3','Intelig�ncia Artific','Pelotas','333');
INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');

INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('2','Zico','1','Oper�rio','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('9','Pel�','1','Oper�rio','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Rom�rio','1','Oper�rio','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Ant�nio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


Finalmente, execute os comandos no shell do Management Studio:

-- Sele��o de todos os campos (ou colunas) da tabela de Departamentos.


            -- where
            --
            -- Operadores l�gicos
            --
            -- operador significado
            -- =  igual a
            -- >  maior que
            -- >= maior que ou igual a
            -- <  menor que
            -- <= menor que ou igual a


-- Selecione todos os departamentos cujo or�amento mensal
--seja maior que 10000. Apresente o Nome de tal departamento
--e seu or�amento anual, que ser� obtido multiplicando-se o
--or�amento mensal por 12.

SELECT Departamento.orcamento * 12
FROM Departamento
WHERE Departamento.orcamento >= 10000;


-- Apresente a instru��o anterior por�m ao inv�s dos
--'feios' DepNome e DepOrca, os T�tulos Departamento e Or�amento.

SELECT  Departamento.nome as DEPARTAMENTO, Departamento.orcamento * 12 as ORCAMENTO_ANUAL 
FROM  Departamento
WHERE Departamento.orcamento >= 10000;


-- Apresente todos os cargos existentes na empresa,
-- por�m omita eventuais duplicidades.

SELECT DISTINCT Empregado.funcao from Empregado;

-- Apresente os nomes e fun��es da cada funcion�rio contidos
--na tabela empregado, por�m classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).

SELECT Empregado.nome AS Nome_Empregado, Empregado.funcao AS Cargo
FROM Empregado
ORDER BY  Empregado.nome;

SELECT Empregado.nome AS Nome_Empregado, Empregado.funcao AS Cargo
FROM Empregado
ORDER BY  Empregado.nome desc;

        -- Demais Operadores
        --
        --Operador                  significado
        --between  ...  and ...     entre dois valores ( inclusive )
        --in ( .... )               lista de valores
        --like                      com um padrao de caracteres
        --is null                   � um valor nulo


        -- Operadores Negativos
        --
        --operador               descri��o
        --<>                     diferente
        --not nome_coluna =      diferente da coluna
        --not nome_coluna >      n�o maior que
        --not between            n�o entre dois valores informados
        --not in                 n�o existente numa dada lista de valores
        --not like               diferente do padrao de caracteres informado
        --is not null            n�o � um valor nulo

-- Selecione os Empregados cujos sal�rios sejam
--menores que 1000 ou maiores que 3500.

SELECT Empregado.nome, Empregado.salario 
FROM Empregado
WHERE Empregado.Salario BETWEEN 1000 AND 3500;

-- Apresente todos os funcion�rios com sal�rios
--entre 3400 e 4000 e que sejam balconistas.

	SELECT Empregado.nome, Empregado.salario 
	FROM Empregado
	WHERE Empregado.Salario BETWEEN 3400 AND 4000 
	AND Empregado.funcao = 'BALCONISTA' ;


    -- Operadores  'AND' (E) e  'OR' (OU).

-- Apresente todos os funcion�rios com sal�rios
--entre 3400 e 4000 ou que sejam balconistas.
	SELECT Empregado.nome, Empregado.salario 
	FROM Empregado
	WHERE Empregado.Salario BETWEEN 3400 AND 4000 
	AND Empregado.funcao = 'BALCONISTA' ;


-- Apresente o nome de todos os empregados em letras min�sculas.

	SELECT UPPER( Empregado.nome )
	FROM Empregado;
	

        -- Fun��es de Caracteres
        --Lower - 		for�a caracteres mai�sculos aparecerem em min�sculos.
        --Upper - 		for�a caracteres min�sculos aparecerem em mai�sculos.
        --Concat(x,y)- 		concatena a string 'x' com a string 'y'.
        --Substring(x,y,str)- 	extrai um substring da string 'str', come�ando em 'x', e termina em 'y'.
        --To_Char(num)- 	converte um valor num�rico para  uma string de caracteres.
        --To_Date(char,fmt)- 	converte uma string caracter em uma data.


-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).

SELECT SUBSTRING ( Empregado.nome, 1,5 )
	FROM Empregado;

-- Apresente a M�dia, o Maior, o Menor e tamb�m a Somat�ria
--dos Sal�rios pagos aos empregados.

SELECT AVG ( Empregado.Salario) AS Media_Salarial
FROM Empregado;

SELECT MAX ( Empregado.Salario) AS Maior_Salario
FROM Empregado;

SELECT MIN ( Empregado.Salario) AS Menor_Salario
FROM Empregado


        -- Fun��es Agregadas (ou de Agrupamento)
        --
        --fun��o        retorno
        --avg(n)        m�dia do valor n, ignorando nulos
        --count(expr)   vezes que o n�mero da expr avalia para algo nao nulo
        --max(expr)     maior valor da expr
        --min(expr)     menor valor da expr
        --sum(n)	       soma dos valores de n, ignorando nulos


-- Apresente a m�dia de comiss�o pagos por departamento.
UPDATE Empregado SET comissao = null where comissao = '0';

SELECT  AVG(Empregado.comissao)  
FROM  Empregado;




--  Retome o problema anterior, por�m apresente resposta
--apenas para departamentos com mais de 2 empregados.


SELECT  Empregado.Departamento_idDepartamento, AVG(Empregado.comissao)
FROM  Empregado
GROUP BY Empregado.Departamento_idDepartamento
HAVING COUNT(*) > 2;




-- Listar Nomes de Empregados, Cargos e
--Nome do Departamento onde o empregado trabalha.

SELECT A.nome, A.funcao, B.nome
FROM Empregado as A, Departamento as B
WHERE B.idDepartamento = A.Departamento_idDepartamento;

--neste caso, o uso de ALIAS � desnecess�rio


-- Liste os C�digos de Cada Funcion�rio, seus Nomes, seus Cargos
--e o nome do Gerente ao qual este se relaciona.

SELECT  A.idEmpregado, A.nome, A.funcao, B.nome AS CHEFE
FROM  Empregado A, Empregado B
WHERE  A.idGerente  = B.idEmpregado;

-- neste caso, o uso de ALIAS � fundamental




-- execute e avalie os comandos
-- INSERT
INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

-- UPDATE
UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;

-- DELETE
DELETE FROM Empregado
WHERE Empregado.salario > 5000;


-- Relacione todos os nomes de funcion�rios e seus respectivos
--cargos, desde que o or�amento do departamento seja igual a 10000.

SELECT Empregado.nome , Empregado.funcao
FROM Empregado , Departamento
WHERE Departamento.orcamento >= 10000 and 
	Departamento.idDepartamento = Empregado.Departamento_idDepartamento;

	SELECT Empregado.nome , Empregado.funcao
	from Departamento
	inner join empregado 
	on departamento.orcamento >= 10000 and Departamento.idDepartamento = Empregado.Departamento_idDepartamento;



-- Relacione todos os departamentos que possuem
--empregados com remunera��o maior que 3000.
	

	SELECT	Empregado.Departamento_idDepartamento, Departamento.nome, Empregado.nome
	FROM Empregado
	inner join Departamento 
	on Empregado.salario >= 3000 and Departamento.idDepartamento = Empregado.Departamento_idDepartamento;
