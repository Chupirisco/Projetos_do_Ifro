"use client";

import { createContext, useContext, useState } from "react";
import { tarefas } from "../models/tarefas";
import { pegarDiaDeHoje } from "../utils/datas";

//contexto
const TarefasContext = createContext();

//provider em react + js
export function TarefasProvider({ children }) {
  const [lista, setLista] = useState(tarefas.lista);
  const [listaFiltro, setListaFiltro] = useState(tarefas.lista);

  //editar
  const editarTarefa = (id, nome, prioridade) => {
    const novasTarefas = lista.map(
      (tarefa) =>
        tarefa.id === id
          ? {
              ...tarefa,
              nome: nome,
              prioridade: prioridade,
              dataCriacao: pegarDiaDeHoje(),
            } // atualiza só essa tarefa
          : tarefa // mantém as outras iguais
    );
    setLista(novasTarefas);
    setListaFiltro(novasTarefas);
  };

  //alterar conclusão
  const alterarConclusao = (index, value) => {
    const novasTarefas = [...lista];
    novasTarefas[index] = { ...novasTarefas[index], ...value };
    setLista(novasTarefas);
    setListaFiltro(novasTarefas);
  };

  //excluir
  const excluirTarefa = (id) => {
    const novasTarefas = lista.filter((tarefa) => tarefa.id !== id);

    setLista(novasTarefas);
    setListaFiltro(novasTarefas);
  };

  //adicionar
  const adicionarTarefa = (nome, prioridade) => {
    const novasTarefas = [...lista];
    const objTarefa = {
      id:
        novasTarefas.length === 0
          ? novasTarefas.length
          : novasTarefas.length + 1,
      nome: nome,
      prioridade: prioridade,
      dataCriacao: pegarDiaDeHoje(),
      concluida: "pendente",
    };
    novasTarefas.push(objTarefa);
    setLista(novasTarefas);
    setListaFiltro(novasTarefas);
  };

  //filtrar
  const filtrarTarefas = (campo, valor) => {
    if (campo === "todos") {
      setListaFiltro(lista);
      return;
    }
    const listaFiltrada = lista.filter((filtro) => filtro[campo] === valor);
    setListaFiltro(listaFiltrada);
  };

  const filtrarPorNome = (value) => {};

  //contagem

  return (
    <TarefasContext.Provider
      value={{
        lista,
        listaFiltro,
        filtrarTarefas,
        editarTarefa,
        alterarConclusao,
        excluirTarefa,
        adicionarTarefa,
      }}
    >
      {children}
    </TarefasContext.Provider>
  );
}

// Hook customizado para consumir o contexto
export const useTarefas = () => useContext(TarefasContext);
