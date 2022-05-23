# .Net Senior Developer Guide

## Language

### OOP

#### Inherent

**Problem:** Eu preciso modelar um sistema para resturante onde eu tenho no meu cardápio vários tipos de pratos. O meu sistema deve conter a receita desses pratos juntamente levando em conta o tipo de ingrediente, quantidade e unidade de medida. Ex.: 

> Exemplo de receita:
>
> *Feijoada*
>
>* 1 Kg de feijão preto
>* 100 g de carne seca
>* 70 g de orelha de porco
>* 70 g de rabo de porco
>* 70 g de pé de porco
>* 100 g de costelinha de porco
>* 50 g de lombo de porco
>* 100 g de paio
>* 150 g de lingüiça portuguesa
>* 2 cebolas grandes picadinhas
>* 1 maço de cebolinha verde picadinha
>* 3 folhas de louro
>* 6 dentes de alho
>* Pimenta do reino a gosto
>* 1 ou 2 laranjas
>* 40 ml de de pinga


### Boxing & Unboxing

**Problem:** Estamos tendo alguns problemas de performance na aplicação. O arquiteto esta suspeito de trechos de código onde atributos do tipo `object` estão sendo usados com muita frequência para dar 'flexibilidade' a alguns cálculos.

```c#
// Exemplo
public static object Incrementador(object valor)
{
    if (valor is int){
        var result = ((int)valor);
        return result += 1;
    }
    else {
        var result = ((double)valor);
        return result += 1;
    }
}

```

Pergunta: Por que o arquiteto suspeita que esse trecho de código pode causar degradação na performance?


### Patterns & Conventions

### DRY


## Tools

## Database

## Server

## Others