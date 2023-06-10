import { IconWithText } from "./IconWithText";
import { BsClipboard2Plus } from "react-icons/bs";
import { TfiPencilAlt } from "react-icons/tfi";
import { BsClipboard2Check } from "react-icons/bs";
import { MdEventRepeat } from "react-icons/md";

export const IconsSection = () => {
  return (
    <section className="flex flex-col items-center mb-20">
      <h2 className="text-center max-md:text-lg text-2xl mb-10 font-bold">Don`t waste your time!</h2>
      <div className="flex justify-between">
        <IconWithText icon={<BsClipboard2Plus />} description="Create Tasks" />
        <IconWithText icon={<TfiPencilAlt />} description="Organize your day" />
        <IconWithText icon={<BsClipboard2Check />} description="Complete Tasks" />
        <IconWithText icon={<MdEventRepeat />} description="Repeat" />
      </div>
    </section>
  );
};
