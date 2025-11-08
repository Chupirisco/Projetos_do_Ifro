"use client";

import { FaClipboard, FaClipboardList, FaEdit, FaTrash } from "react-icons/fa";
import styles from "../../styles/body/Corpo.module.css";
import { useTarefas } from "../../context/TarefasContext";
import { useState } from "react";
import { ModalDeEditar } from "../modals/modalEditar";
import { ModalDeExlusão } from "../modals/modalExcluir";

export function Corpo() {
  // provider da lista de tarefas
  const { listaFiltro, alterarConclusao } = useTarefas();

  // altenar entre concluida e pendente
  const handleCheckboxChange = (index) => {
    const tarefa = listaFiltro[index];
    const novoValor =
      tarefa.concluida === "pendente" ? "concluida" : "pendente";
    alterarConclusao(index, { concluida: novoValor });
  };

  // controlador do model
  const [modelAberto, setEmodelAberto] = useState(null);
  const [tarefaSelecionada, setTarefaSelecionada] = useState(null);

  // funções que alternam entre o model aberto e fechado
  const abrirModelEditar = (tarefa) => {
    setTarefaSelecionada(tarefa);
    setEmodelAberto("editar");
  };

  const abrirModelExcluir = (tarefa) => {
    setTarefaSelecionada(tarefa);
    setEmodelAberto("excluir");
  };

  const fecharModel = (tarefa) => {
    setTarefaSelecionada(null);
    setEmodelAberto(false);
  };

  return listaFiltro && listaFiltro.length !== 0 ? (
    <div className={styles.listaTarefasContainer}>
      <ul className={styles.listaDeTarefas} id="listaDeTarefas">
        {listaFiltro.map((tarefa, index) => (
          <li
            key={index}
            className={`${styles.taskItens} ${styles[tarefa.concluida]}`}
          >
            <input
              className={styles.tarefasCheckbox}
              type="checkbox"
              checked={tarefa.concluida === "concluida"}
              onChange={() => handleCheckboxChange(index)}
            />
            <span className={styles.texto}>{tarefa.nome}</span>
            <span
              className={`${styles.prioridade} ${styles[tarefa.prioridade]}`}
            >
              {tarefa.prioridade}
            </span>

            <span className={styles.tarefasData}>{tarefa.dataCriacao}</span>
            <div className={styles.acoes}>
              <button
                className={styles.btnEditar}
                onClick={() => abrirModelEditar(tarefa)}
              >
                <FaEdit /> Editar
              </button>
              <button
                className={styles.btnDeletar}
                onClick={() => abrirModelExcluir(tarefa)}
              >
                <FaTrash /> Excluir
              </button>
            </div>
          </li>
        ))}
      </ul>
      {modelAberto === "editar" && (
        <ModalDeEditar
          provTarefa={tarefaSelecionada}
          funcaoFecharModel={fecharModel}
        />
      )}
      {modelAberto === "excluir" && (
        <ModalDeExlusão
          provTarefa={tarefaSelecionada}
          funcaoFecharModel={fecharModel}
        />
      )}
    </div>
  ) : (
    <div className={styles.listaTarefasContainer}>
      <div className={styles.listaDeTarefasVazia} id="listaDeTarefasVazia">
        <FaClipboardList className={styles.icone} />
        <h3>Nenhuma tarefa encontrada</h3>
        <p>Adicione uma nova tarefa para começar!</p>
      </div>
    </div>
  );
}
