import { ComponentProps } from "react";

type props = {
  withColor?: boolean;
  content: any;
} & Omit<ComponentProps<"button">, "className">;

export const LayoutButton = ({ withColor = false, content, ...props }: props) => {
  return (
    <button {...props} className={`max-md:m-0 px-3 py-1 mx-2 my-1 rounded-lg ${withColor && "bg-main text-white"}`}>
      {content}
    </button>
  );
};
