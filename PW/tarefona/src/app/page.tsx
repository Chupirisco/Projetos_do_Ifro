import styles from "./page.module.css";
import React from "react";
import { Menu } from "../components/menu";
import { Principal } from "../components/body/Principal";
import { Model } from "../components/modals/model";
import { TarefasProvider } from "../context/TarefasContext";

export default function Page() {
  return (
    <TarefasProvider>
      <div className={styles.container}>
        <Menu />
        <Principal />
      </div>
    </TarefasProvider>
  );
}
