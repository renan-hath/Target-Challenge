4. Uma empresa solicitou a você um aplicativo para manutenção de um cadastro de clientes. Após a reunião de definição dos requisitos, as conclusões foram as seguintes:

   - Um cliente pode ter um número ilimitado de telefones;
   - Cada telefone de cliente tem um tipo, por exemplo: comercial, residencial, celular, etc. O sistema deve permitir cadastrar novos tipos de telefone;
   - A princípio, é necessário saber apenas em qual estado brasileiro cada cliente se encontra. O sistema deve permitir cadastrar novos estados;

   Você ficou responsável pela parte da estrutura de banco de dados que será usada pelo aplicativo. Assim sendo:

   - Proponha um modelo lógico para o banco de dados que vai atender a aplicação. Desenhe as tabelas necessárias, os campos de cada uma e marque com setas os relacionamentos existentes entre as tabelas;
   - Aponte os campos que são chave primária (PK) e chave estrangeira (FK);
   - Faça uma busca utilizando comando SQL que traga o código, a razão social e o(s) telefone(s) de todos os clientes do estado de São Paulo (código “SP”);

> - O modelo lógico do banco de dados pode ser visualizado na imagem [Desafio04_Modelo_Logico](../Desafio04/Desafio04_Modelo_Logico.png).
>
> - As chaves primárias e estrangeiras do banco de dados estão listadas a seguir:
>
>   • Tabela Clientes
>
>   ​	Chave primária: ClienteID
>
>   ​	Chave estrangeira: EstadoID
>
>   • Tabela Estados
>
>   ​	Chave primária: EstadoID
>
>   • Tabela Telefones
>
>   ​	Chave primária: TelefoneID
>
>   ​	Chave estrangeira: ClienteID
>
> - O comando SQL abaixo pode trazer o código, razão social e telefones dos clientes do estado de São Paulo:
>
> ```mysql
> SELECT
>     c.ClienteID AS Codigo,
>     c.RazaoSocial AS RazaoSocial,
>     t.Numero AS Telefone
> FROM
>     Clientes c
>     INNER JOIN Estados e ON c.EstadoID = e.EstadoID
>     INNER JOIN Telefones t ON c.ClienteID = t.ClienteID
> WHERE
>     e.Sigla = 'SP';
> ```
>
> 
