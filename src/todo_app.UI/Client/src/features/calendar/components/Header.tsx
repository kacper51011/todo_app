type props = {
  year: string;
  month: string;
};

export const Header = ({ year, month }: props) => {
  return (
    <header className="flex justify-between mb-2 max-md:px-2 max-md:py-3 px-6 py-7 items-center">
      <p aria-label="Month of chosen calendar page" className="font-bold max-md:text-xl text-5xl text-lightText">
        {month}
      </p>
      <p aria-label="Year of chosen calendar page" className="font-bold max-md:text-2xl text-6xl text-lightDarkText">
        {year}
      </p>
    </header>
  );
};
