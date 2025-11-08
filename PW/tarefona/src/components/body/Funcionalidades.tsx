"use client";

import { FaPlus, FaSearch, FaTrash, FaTrashAlt } from "react-icons/fa";
import styles from "../../styles/body/Funcionalidades.module.css";
import { useState } from "react";
import { useTarefas } from "../../context/TarefasContext";

export function CampoAdicionarTarefa() {
  const { adicionarTarefa } = useTarefas();

  const [nome, setNome] = useState(null);
  const [prioridade, setPrioridade] = useState("media");

  const atualizarNome = (valor) => setNome(valor);
  const atualizarPrioridade = (valor) => setPrioridade(valor);

  const handleClickButton = () => {
    if (nome === null) {
      return;
    }

    adicionarTarefa(nome, prioridade);
    setNome(null);
    setPrioridade("media");
  };

  return (
    <div className={styles.containerInput}>
      <div className={styles.containerGrupoInput}>
        <input
          value={nome || ""}
          className={styles.iptAdicionarTarefa}
          id="iptAdicionarTarefa"
          type="text"
          placeholder="Digite uma nova tarefa"
          maxLength={100}
          onChange={(e) => atualizarNome(e.target.value)}
        />
        <select
          className={styles.sltPrioridade}
          id="sltPrioridade"
          defaultValue="media"
          onChange={(e) => atualizarPrioridade(e.target.value)}
        >
          <option value="baixa">Baixa</option>
          <option value="media">Média</option>
          <option value="alta">Alta</option>
        </select>
        <button
          className={styles.btnAdicionarTarefa}
          id="btnAdicionarTarefa"
          type="submit"
          onClick={handleClickButton}
        >
          <FaPlus /> Adicionar
        </button>
      </div>
    </div>
  );
}

export function CampoFiltrarTarefas() {
  const { lista, filtrarTarefas } = useTarefas();

  //filtrar por tipo
  const handleSelect = (valor) => {
    if (valor === "todos") return filtrarTarefas(valor, null);
    if (valor === "concluida" || valor === "pendente") {
      return filtrarTarefas("concluida", valor);
    } else {
      return filtrarTarefas("prioridade", valor);
    }
  };

  //filtar por nome
  const handleInput = (value) => {};

  //statisticas
  const handleTotal = () => {
    return lista.length.toString();
  };

  const handleConcluidas = () => {
    const listaConcluidas = lista.filter(
      (tarefa) => tarefa.concluida === "concluida"
    );
    return listaConcluidas.length.toString();
  };

  const handlePendentes = () => {
    const listaPendentes = lista.filter(
      (tarefa) => tarefa.concluida === "pendente"
    );
    return listaPendentes.length.toString();
  };
  return (
    <div className={styles.containerFiltro}>
      <div className={styles.grupoSlt}>
        <label htmlFor="sltFiltrarTarefas">Filtrar Por</label>
        <select
          className={styles.sltFiltrarTarefas}
          id="sltFiltrarTarefas"
          defaultValue="todos"
          onChange={(e) => handleSelect(e.target.value)}
        >
          <option value="todos">Todas</option>
          <option value="pendente">Pendentes</option>
          <option value="concluida">Concluidas</option>
          <option value="alta">Prioridade Alta</option>
          <option value="media">Prioridade Média</option>
          <option value="baixa">Prioridade baixa</option>
        </select>
      </div>
      <div className={styles.grupoIpt}>
        <input
          className={styles.iptFiltrar}
          id="iptFiltrar"
          type="text"
          placeholder="Buscar tarefas..."
          onChange={(e) => handleInput(e.target.value)}
        />
        <FaSearch className={styles.icone} />
      </div>

      <div className={styles.grupoSpn}>
        <span>Total: {handleTotal()}</span>
        <span>Concluídas: {handleConcluidas()}</span>
        <span>Pendentes: {handlePendentes()}</span>
      </div>
    </div>
  );
}

export function CampoAcoes() {
  return (
    <div className={styles.acoesContainer}>
      <button className={styles.btnLimparConcluidas} id="btnLimparConcluidas">
        <FaTrash /> Limpar Concluídas
      </button>
      <button className={styles.btnLimparTudo} id="btnLimparTudo">
        <FaTrashAlt /> Limpar Todas
      </button>
    </div>
  );
}
