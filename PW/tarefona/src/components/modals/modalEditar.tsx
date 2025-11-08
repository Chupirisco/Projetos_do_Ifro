import { useState } from "react";
import { useTarefas } from "../../context/TarefasContext";
import styles from "../../styles/Model.module.css";
import { Model } from "./model";

export function ModalDeEditar(props: any) {
  //metodo do provider
  const { editarTarefa } = useTarefas();

  //controladores
  const [nome, setNome] = useState(props.provTarefa.nome);
  const [prioridade, setPrioridade] = useState(props.provTarefa.prioridade);

  //função
  const handleInputSubmit = () => {
    editarTarefa(props.provTarefa.id, nome, prioridade);
    props.funcaoFecharModel();
  };
  return (
    <Model titulo="Editar" funcaoFecharModel={props.funcaoFecharModel}>
      <div className={styles.modalCorpo}>
        <input
          type="text"
          id="iptEditar"
          className={styles.iptEditar}
          value={nome}
          onChange={(e) => setNome(e.target.value)}
        />
        <select
          id="sltEditarPrioridade"
          defaultValue={prioridade}
          onChange={(e) => setPrioridade(e.target.value)}
        >
          <option value="baixa">Baixa</option>
          <option value="media">Média</option>
          <option value="alta">Alta</option>
        </select>
      </div>
      <div className={styles.modalRodape}>
        <button
          id="btnSalvarEdicao"
          className={styles.btnSalvarEdicao}
          onClick={() => handleInputSubmit()}
        >
          Salvar
        </button>
        <button
          id="btnCancelarEdicao"
          className={styles.btnCancelar}
          onClick={() => props.funcaoFecharModel()}
        >
          Cancelar
        </button>
      </div>
    </Model>
  );
}
