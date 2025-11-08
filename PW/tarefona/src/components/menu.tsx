import React from "react";
import styles from "../styles/Menu.module.css";
import { FaTasks } from "react-icons/fa";

export function Menu() {
    return (
        <header className={styles.menu}>
            <div className={styles.alinhar}>
                <FaTasks size={40} color="#fff" />
                <h1>Minha Lista de Tarefas</h1>
            </div>

            <p className={styles.subtitulo}>Organize suas atividades de forma eficiente</p>
        </header>
    )
}