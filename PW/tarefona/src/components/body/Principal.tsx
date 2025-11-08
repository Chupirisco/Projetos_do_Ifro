import React from "react";
import styles from "../styles/body/Principal.module.css";
import {
  CampoAcoes,
  CampoAdicionarTarefa,
  CampoFiltrarTarefas,
} from "./Funcionalidades";
import { Corpo } from "./Corpo";

export function Principal() {
  return (
    <div>
      <CampoAdicionarTarefa />
      <CampoFiltrarTarefas />

      <Corpo />
      <CampoAcoes />
    </div>
  );
}
