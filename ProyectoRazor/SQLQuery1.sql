use GuillermoDiscos
go

select c.id
from Cliente as c
	inner join Puntuacion as p
	on c.id = p.Idcliente
group by c.id
having count(p.Puntuacion) = 1

select Titulo, tipo 
from Disco as d inner join
	DiscoTipo as dt on d.IdDisco = dt.IdDisco
	inner join Tipo as t on dt.IdTipo = t.IdTipo
