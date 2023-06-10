import { LastSectionHero } from "../../shared/assets";

export const LastSection = () => {
  return (
    <section className="flex w-2/3 mb-20">
      <div className="w-2/3">
        <LastSectionHero width="100%" height="" />
      </div>
      <div className="flex flex-col justify-start items-start w-1/3">
        <h2 className="font-bold mb-4 ml-3">Be a better version of yourself!</h2>
        <button className="px-10 py-2 ml-3 bg-main text-white rounded-md font-bold">Start today</button>
      </div>
    </section>
  );
};
