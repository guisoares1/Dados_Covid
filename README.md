# Objetivo

Capturar dados de mortes e casos de COVID-19 dos últimos 6 meses no endpoints [CovidPostmam](https://documenter.getpostman.com/view/10808728/SzS8rjbc). Com esses dados deve ser mostrado uma média móvel de cada um dos tipos inseridos, separados por semanas (3).

# Descrição

## Back-End ​

Para inserção, foi utilizado a estratégia de atualizar automáticamente a base de dados. Caso a base esteja vazia é preenchido com dados dos últimos 6 meses. Caso tenha dado é verificado a data do último registro e preenchido a partir daí.

Para a utilização do front-end, foi criado um get() de mortes e casos, onde é passado o número da semana desejada.
```c ​
".../Casos/{Id}"
".../Mortes/{Id}"
```
## Front-End
Foi feito em React. Foi criado 4 abas para apresentação separada das informações. 

Para cálculo da média móvel foi utilizado a seguinte formula:

![alt text](https://github.com/guisoares1/Imagens/blob/main/3.png)

Prints da pagina WEB:

![alt text](https://github.com/guisoares1/Imagens/blob/main/1.png)

![alt text](https://github.com/guisoares1/Imagens/blob/main/2.png)
