using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;

namespace TwoDoLanguages
{
    class Portuguese : ITwoDoLanguage
    {
        //Languages
        public string _Language { get { return "Linguagem"; } }
        public string _English { get { return "Inglês"; } }
        public string _Portuguese { get { return "Português"; } }

        //Main Menu Buttons
        public string File { get { return "Arquivo"; } }
        public string Edit { get { return "Editar"; } }
        public string Character { get { return "Personagem"; } }
        public string Map { get { return "Mapa"; } }
        public string Skill { get { return "Habilidade"; } }
        public string Item { get { return "Item"; } }
        public string Quest { get { return "Missão"; } }
        public string Lore { get { return "História"; } }
        public string Options { get { return "Opções"; } }
        public string Misc { get { return "Diverso"; } }

        //Toolbar File
        public string NewProject { get { return "Novo Projeto"; } }
        public string OpenProject { get { return "Abrir Projeto"; } }
        public string RenameProject { get { return "Renomear Projeto"; } }
        public string Save { get { return "Salvar"; } }
        public string SaveAll { get { return "Salvar Todos"; } }
        public string Import { get { return "Importar"; } }
        public string Export { get { return "Exportar"; } }
        public string Exit { get { return "Sair"; } }

        //Toobar Edit
        public string Undo { get { return "Desfazer"; } }
        public string Redo { get { return "Refazer"; } }
        public string Duplicate { get { return "Duplicar"; } }
        public string Delete { get { return "Deletar"; } }
        public string SelectAll { get { return "Selecionar Todos"; } }
        public string Sort { get { return "Ordenar"; } }

        //ToolBar Char
        public string NewCharacter { get { return "Novo Personagem"; } }
        public string SetAttributes { get { return "Editar Atributos"; } }
        public string SetSprites { get { return "Editar Sprites"; } }
        public string SetAnimation { get { return "Editar Animação"; } }
        public string AddLore { get { return "Adicionar História"; } }
        public string AddSkill { get { return "Adicionar Habilidade"; } }

        //ToolBar Map
        public string NewMap { get { return "Novo Mapa"; } }
        public string AddLink { get { return "Adicionar Conexão"; } }
        public string AddCharacters { get { return "Adicionar Personagem"; } }
        public string AddItens { get { return "Adicionar Item"; } }
        public string SpawnPoint { get { return "Ponto de Geração"; } }

        //ToolBar Item
        public string NewItem { get { return "Novo Item"; } }
        public string EditItem { get { return "Editar Item"; } }
        public string Search { get { return "Buscar"; } }

        //ToolBar Quest
        public string NewQuest { get { return "Nova Missão"; } }
        public string EditQuest { get { return "Editar Missão"; } }
        public string CheckCompletation { get { return "Verificar integridade"; } }

        //ToolBar Skill
        public string NewSkill { get { return "Nova Habilidade"; } }
        public string EditSkill { get { return "Editar Habilidade"; } }

        //ToolBar Lore
        public string NewLore { get { return "Nova Descrição"; } }
        public string Storyline { get { return "Enredo"; } }
        public string NewLinkWord { get { return "Nova Palavra-Chave"; } }

        //ToolBar Options
        public string Editor { get { return "Editor"; } }
        public string Preferences { get { return "Preferências"; } }

        //ToolBar Misc.
        public string CustomAttributes { get { return "Adicionar Atributo"; } }
        public string ElementTable { get { return "Tabela de Elementos"; } }
        public string CustomCharacterType { get { return "Adicionar Tipo de Personagem"; } }
        public string Scripts { get { return "Scripts"; } }

        //character attributes
        public string Strength { get { return "Força"; } }
        public string Inteligence { get { return "Inteligencia"; } }
        public string Dexterity { get { return "Dextreza"; } }
        public string Vitality { get { return "Vitalidade"; } }
        public string BaseHP { get { return "HP Base"; } }
        public string BaseMP { get { return "MP Base"; } }
        public string Luck { get { return "Sorte"; } }
        public string MinLevel { get { return "Level Min."; } }
        public string Name { get { return "Nome"; } }
        public string SelectImage { get { return "Selecionar Imagem"; } }
        public string Add { get { return "Adicionar"; } }
        public string Advanced { get { return "Avançado"; } }
    }
}
