# Objetivo

Capturar dados de mortes e casos de COVID-19 dos últimos 6 meses no endpoints [CovidPostmam](https://documenter.getpostman.com/view/10808728/SzS8rjbc). Com esses dados deve ser mostrado uma média móvel de cada um dos tipos inseridos, separados por semanas (3).

# Descrição

## Back-End ​

A tecnologia utilizada para desenvolvimento foi o [.NET Core.](https://dotnet.microsoft.com/download).

Para inserção, foi utilizado a estratégia de atualizar automáticamente a base de dados. Caso a base esteja vazia é preenchido com dados dos últimos 6 meses. Caso tenha dado é verificado a data do último registro e preenchido a partir daí.

Para cálculo da média móvel foi utilizado a seguinte formula:

![alt text](https://github.com/guisoares1/Imagens/blob/main/3.png)

Para a utilização do front-end, foi criado um get() de mortes e casos, onde é passado o número da semana desejada.
```c ​
".../Casos/{Id}"
".../Mortes/{Id}"
```
## Front-End
Foi feito em [React](https://pt-br.reactjs.org/). Foi criado 4 abas para apresentação separada das informações. 

Prints da pagina WEB:

![alt text](https://github.com/guisoares1/Imagens/blob/main/1.png)

![alt text](https://github.com/guisoares1/Imagens/blob/main/2.png)
