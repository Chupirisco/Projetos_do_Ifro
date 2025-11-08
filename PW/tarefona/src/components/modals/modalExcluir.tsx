import { Model } from "./model";
import styles from "../../styles/Model.module.css";
import { useTarefas } from "../../context/TarefasContext";

export function ModalDeExlusão(props: any) {
  const { excluirTarefa } = useTarefas();

  const handleClickButton = () => {
    excluirTarefa(props.provTarefa.id);
    props.funcaoFecharModel();
  };

  return (
    <Model titulo="Excluir" funcaoFecharModel={props.funcaoFecharModel}>
      <div className={styles.modalCorpo}>
        <p className={styles.texto}>
          Tem certeza que deseja excluir{" "}
          <strong>{props.provTarefa.nome}</strong>?
        </p>
      </div>

      <div className={styles.modalRodape}>
        <button className={styles.btnDeletar} onClick={handleClickButton}>
          Sim
        </button>
        <button
          className={styles.btnCancelar}
          onClick={() => props.funcaoFecharModel()}
        >
          Não
        </button>
      </div>
    </Model>
  );
}
