import { Container } from "./components/Container";
import { DaysNamesRow } from "./components/DaysNamesRow";
import { Header } from "./components/Header";
import { WeeksRows } from "./components/WeeksRows";

export const Calendar = () => {
  return (
    <Container>
      <Header year="2023" month="September" />
      <DaysNamesRow />
      <WeeksRows />
    </Container>
  );
};
