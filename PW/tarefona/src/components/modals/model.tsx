import styles from "../../styles/Model.module.css";

export function Model(props: any) {
  return (
    <div id="modalDeEdicao" className={styles.modalDeEdicao}>
      <div className={styles.modelContainer}>
        <div className={styles.modalCabecalho}>
          <h3>{props.titulo} Tarefa</h3>
          <span
            className={styles.close}
            onClick={() => props.funcaoFecharModel()}
          >
            &times;
          </span>
        </div>

        {props.children}
      </div>
    </div>
  );
}
