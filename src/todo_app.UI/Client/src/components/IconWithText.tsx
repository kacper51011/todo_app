import { ReactNode } from "react";
import { IconBase } from "react-icons";

type props = {
  icon: ReactNode;
  description: string;
};

export const IconWithText = ({ icon, description }: props) => {
  return (
    <div className="flex flex-col items-center max-md:mx-2 mx-10">
      <IconBase className="max-md:text-[35px] text-[50px] mb-5 text-main">{icon}</IconBase>
      <span className="max-md:text-sm text-lg text-center">{description}</span>
    </div>
  );
};
