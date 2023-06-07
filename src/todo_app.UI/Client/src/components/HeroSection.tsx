import { Hero } from "../shared/assets";

export const HeroSection = () => {
  return (
    <section className="flex flex-col items-center mb-20">
      <h1 className="text-center max-md:text-lg text-2xl mb-10 font-bold">
        Organize your day activity with <br /> Todo App
      </h1>
      <button className="px-10 py-2 bg-main text-white rounded-md font-bold">Start today</button>
      <Hero className=" h-[500px]" />
    </section>
  );
};
