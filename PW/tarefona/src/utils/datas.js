export function pegarDiaDeHoje() {
  const data = new Date();
  return data.toLocaleDateString("pt-BR");
}
